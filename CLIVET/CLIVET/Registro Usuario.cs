using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CLIVET
{
    public partial class Registro_Usuario : Form
    {
        public Registro_Usuario(string user, int LVL)
        {
            InitializeComponent();
            User = user;
            NivelesAcces();
            nivel = LVL;
            pnUsuarios.Hide();
        }
        private string query = "";
        private string estado = "";
        DataTable dt = new DataTable();
        private string User = "";
        private int nivel = 0;
        private string btuser1 = "";
        private string btuser2 = "";
        private string btuser3 = "";
        private string btuser4 = "";

        private void NivelesAcces()
        {
            query = "EXECUTE NivelesAcces;";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = Connection.CnnStr;
            Conexion.Open();
            SqlCommand comand = new SqlCommand(query, Conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            adapter.Fill(dt);
            this.cmblvseguridad.DataSource = dt;
            this.cmblvseguridad.DisplayMember = "TipoNivelAcceso";
            this.cmblvseguridad.ValueMember = "idNivelAcceso";
            comand.Dispose();
            adapter.Dispose();
            dt = new DataTable();
        }

        private void InicioRegistro(string username, string contraseña, string nombre, string apellidop, string apellidom, string nivel)
        {
            query = "EXECUTE InicioRegistro '" + username + "','" + contraseña + "','" + nombre + "','" + apellidop + "'," + apellidom + ",'"+nivel+"';";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = Connection.CnnStr;
            Conexion.Open();
            SqlCommand comand = new SqlCommand(query, Conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            adapter.Fill(dt);
            estado = dt.Rows[0]["Estado"].ToString();
            comand.Dispose();
            adapter.Dispose();
            dt = new DataTable();
        }
        private void ModificarRegistro(string username, string contraseña, string nombre, string apellidop, string apellidom, string nivel)
        {
            query = "EXECUTE ModificRegistro '" + username + "','" + contraseña + "','" + nombre + "','" + apellidop + "'," + apellidom + ",'" + nivel + "';";
            estado = Connection.getData(query).Rows[0]["Estado"].ToString();
            MessageBox.Show(estado);
        }


        private void Registro_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login Li = new Login();
            Li.Show();
            this.Close();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(User,nivel);
            H.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text != "") && (txtcontraseña.Text != "") && (txtusuario.Text != "") && (txtpapellido.Text != "") && (cmblvseguridad.Text != "") && (txtsapellido.Text != ""))
            {
                
                InicioRegistro(txtusuario.Text, txtcontraseña.Text, txtnombre.Text, txtpapellido.Text, txtsapellido.Text,cmblvseguridad.Text);
                MessageBox.Show(estado);
                if (estado == "Se registro correctamente")
                {
                    HOME l = new HOME(User,nivel);
                    l.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Faltan campos de llenar o estan erroneos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "")
            {
                query = "exec EliminarUsuario '" + txtusuario.Text + "'";
                estado=Connection.getData(query).Rows[0]["Estado"].ToString();
                MessageBox.Show(estado);
            }
            else { MessageBox.Show("No ha elejido un usuario"); }
        }
        private void UsuariosBuscar(string user)
        {
            query = "EXECUTE BuscarUsuarios '" + user + "'";
            switch(Connection.getData(query).Rows.Count)
            {
                case 0:
                    btuser1 = "No hay usuario";
                    btuser2 = "No hay usuario";
                    btuser3 = "No hay usuario";
                    btuser4 = "No hay usuario";
                    break;
                case 1:
                    btuser1 = Connection.getData(query).Rows[0]["Usuario"].ToString();
                    btuser2 = "No hay usuario";
                    btuser3 = "No hay usuario";
                    btuser4 = "No hay usuario";
                    break;
                case 2:
                    btuser1 = Connection.getData(query).Rows[0]["Usuario"].ToString();
                    btuser2 = Connection.getData(query).Rows[1]["Usuario"].ToString();
                    btuser3 = "No hay usuario";
                    btuser4 = "No hay usuario";
                    break;
                case 3:
                    btuser1 = Connection.getData(query).Rows[0]["Usuario"].ToString();
                    btuser2 = Connection.getData(query).Rows[1]["Usuario"].ToString();
                    btuser3 = Connection.getData(query).Rows[2]["Usuario"].ToString();
                    btuser4 = "No hay usuario";
                    break;
                case 4:
                    btuser1 = Connection.getData(query).Rows[0]["Usuario"].ToString();
                    btuser2 = Connection.getData(query).Rows[1]["Usuario"].ToString();
                    btuser3 = Connection.getData(query).Rows[2]["Usuario"].ToString();
                    btuser4 = Connection.getData(query).Rows[3]["Usuario"].ToString();
                    break;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            pnUsuarios.Show();
            if(txtusuario.Text=="")
            {
                pnUsuarios.Hide();
            }
            UsuariosBuscar(txtusuario.Text);
            btnUsuario1.Text = btuser1;
            btnUsuario2.Text = btuser2;
            btnUsuario3.Text = btuser3;
            btnUsuario4.Text = btuser4;
            if(btuser1=="No hay usuario")
            {
                btnUsuario1.Enabled = false;
            }
            else
            {
                btnUsuario1.Enabled = true;
            }
            if (btuser2 == "No hay usuario")
            {
                btnUsuario2.Enabled = false;
            }
            else
            {
                btnUsuario2.Enabled = true;
            }
            if (btuser3 == "No hay usuario")
            {
                btnUsuario3.Enabled = false;
            }
            else
            {
                btnUsuario3.Enabled = true;
            }
            if (btuser4 == "No hay usuario")
            {
                btnUsuario4.Enabled = false;
            }
            else
            {
                btnUsuario4.Enabled = true;
            }
        }
        private void SelectUser(string use)
        {
            query = "exec BotonUsuario '" + use + "'";
            txtusuario.Text = Connection.getData(query).Rows[0]["Usuario"].ToString();
            txtcontraseña.Text = Connection.getData(query).Rows[0]["Contraseña"].ToString();
            txtnombre.Text = Connection.getData(query).Rows[0]["NombreUsuario"].ToString();
            txtpapellido.Text= Connection.getData(query).Rows[0]["ApellidoPUsuario"].ToString();
            txtsapellido.Text = Connection.getData(query).Rows[0]["ApellidoMUsuario"].ToString();
            cmblvseguridad.Text = Connection.getData(query).Rows[0]["TipoNivelAcceso"].ToString();
        }

        private void btnUsuario1_Click(object sender, EventArgs e)
        {
            SelectUser(btnUsuario1.Text);
        }

        private void btnUsuario2_Click(object sender, EventArgs e)
        {
            SelectUser(btnUsuario2.Text);
        }

        private void btnUsuario3_Click(object sender, EventArgs e)
        {
            SelectUser(btnUsuario3.Text);
        }

        private void btnUsuario4_Click(object sender, EventArgs e)
        {
            SelectUser(btnUsuario4.Text);
        }


        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text != "") && (txtcontraseña.Text != "") && (txtusuario.Text != "") && (txtpapellido.Text != "") && (cmblvseguridad.Text != "") && (txtsapellido.Text != ""))
            {
                ModificarRegistro(txtusuario.Text, txtcontraseña.Text, txtnombre.Text, txtpapellido.Text, txtsapellido.Text, cmblvseguridad.Text);
                MessageBox.Show(estado);
                if (estado == "El usuario se ha actualizado Correctamente")
                {
                    HOME l = new HOME(User, nivel);
                    l.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan campos de llenar o estan erroneos");
            }
        }
    }
}
