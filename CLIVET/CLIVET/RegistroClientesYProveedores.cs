using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIVET
{
    public partial class RegistroClientesYProveedores : Form
    {
        public RegistroClientesYProveedores(string User, int lvl)
        {
            InitializeComponent();
            user = User;
            lbusuario.Text = user;
            nivel = lvl;
            CiudadesAgregar();
            if (nivel != 1)
            {
                tbcCliente.TabPages.Remove(tabProducto);
            }
        }
        private string Estado = "";
        private string user = "";
        private int nivel = 0;
        private string Query = "";

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user, nivel);
            H.Show();
            this.Close();
        }

        private void CiudadesAgregar()
        {
            Query = "select * from CatCiudad";
            cmbCiudad1.DataSource = Connection.getData(Query);
            cmbCiudad1.DisplayMember = "Ciudad";
            cmbCiudad1.ValueMember = "idCiudad";
            cmbCiudad2.DataSource = Connection.getData(Query);
            cmbCiudad2.DisplayMember = "Ciudad";
            cmbCiudad2.ValueMember = "idCiudad";
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void AgregarCliente(string nombre, string ciudad)
        {
            Query = "exec RegistroCliente '" + nombre + "', '" + ciudad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void ModificarCliente(string nombre, string ciudad)
        {
            Query = "exec ModifCliente '" + nombre + "', '" + ciudad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void AgregarProveedor(string nombre, string ciudad)
        {
            Query = "exec RegistroProveedor '" + nombre + "', '" + ciudad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void ModificarProveedor(string nombre, string ciudad)
        {
            Query = "exec ModifProveedor '" + nombre + "', '" + ciudad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }


        private void AgregarProducto(string nombre, int existencia, int precio)
        {
            Query = "exec RegistroProducto '" + nombre + "', '" + existencia + "','" + precio + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }
        private void ModificarProducto(string nombre, int existencia, int precio)
        {
            Query = "exec ModifProducto '" + nombre + "', '" + existencia + "','" + precio + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }


        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "" && cmbCiudad1.Text != "")
                {
                    AgregarCliente(txtCliente.Text, cmbCiudad1.Text);
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "" && cmbCiudad2.Text != "")
                    {
                        AgregarProveedor(txtCliente.Text, cmbCiudad2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "" && txtExistencia.Text != "" && txtPrecio.Text != "")
                        {
                            AgregarProducto(txtProducto.Text, Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtPrecio.Text));
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }
        private void EliminarValor(string Tabla, string Valor)
        {
            Query = "delete " + Tabla + " where " + Tabla + "='" + Valor + "';";
            Connection.getData(Query);
            MessageBox.Show(Valor + " ha sido eliminado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "")
                {
                    EliminarValor("Cliente", txtCliente.Text);
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "")
                    {
                        EliminarValor("Proveedor", txtProveedor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "")
                        {
                            EliminarValor("Producto", txtProducto.Text);
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "" && cmbCiudad1.Text != "")
                {
                    ModificarCliente(txtCliente.Text, cmbCiudad1.Text);
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "" && cmbCiudad2.Text != "")
                    {
                        ModificarProveedor(txtProveedor.Text, cmbCiudad2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "" && txtExistencia.Text != "" && txtPrecio.Text != "")
                        {
                            ModificarProducto(txtProducto.Text, Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtPrecio.Text));
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }


        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }



        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            { 
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Handled = true;
            return;
        }
    }

        private void tabProducto_Click(object sender, EventArgs e)
        {

        }
    }
    }
