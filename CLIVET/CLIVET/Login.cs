using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CLIVET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string Query = "";
        DataTable dt = new DataTable();
        public string User = "";
        private string Pass = "";
        private bool acces = false;
        private int nivel = 0;

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogIn(string User, string Pass)
        {
            Query = "EXECUTE InicioLogin '" + User + "','" + Pass + "';";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = Connection.CnnStr;
            Conexion.Open();
            SqlCommand comand = new SqlCommand(Query, Conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            adapter.Fill(dt);
            acces = Convert.ToBoolean(dt.Rows[0]["Acces"].ToString());
            comand.Dispose();
            adapter.Dispose();
            dt = new DataTable();
        }

        private void LvlAcces(string User)
        {
            Query = "EXECUTE LogInNivelesAcces '" + User + "';";
            nivel = Convert.ToInt32(Connection.getData(Query).Rows[0]["Acces"].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User = txtUsuario.Text;
            Pass = txtContraseña.Text;
            LogIn(User, Pass);
            if (acces)
            {
                LvlAcces(User);
                HOME ex = new HOME(User, nivel);
                ex.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña estan equivocados");
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
