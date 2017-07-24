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
    public partial class Captura_Proveedores : Form
    {
        public Captura_Proveedores(string User, int lvl)
        {
            InitializeComponent();
            user = User;
            lbusuario.Text = user;
            nivel = lvl;
            llenarDataGrid();
            panel1.Hide();
            panel2.Hide();
            btnmodificar.Hide();
            lb.Hide();
            lbsimbolo.Hide();
            lbcantidad.Hide();
            Llenado_Cmb_Metodo_pago();
        }
        private string user = "";
        private string Query = "";
        private string Estado = "";
        private int nivel = 0;
        private string btuser1 = "";
        private string btuser2 = "";
        private string btuser3 = "";
        private string btuser4 = "";
        private string btuserX = "";

        private void UsuariosBuscar(string user, int numX)
        {
            Query = "EXECUTE BuscadorX '" + user + "'," + numX + "";
            switch (numX)
            {
                case 1:
                    btuserX = "Cliente";
                    break;
                case 2:
                    btuserX = "Producto";
                    break;
                case 3:
                    btuserX = "Pago";
                    break;
                case 4:
                    btuserX = "Proveedor";
                    break;
            }
            switch (Connection.getData(Query).Rows.Count)
            {
                case 0:
                    btuser1 = "No hay " + btuserX;
                    btuser2 = "No hay " + btuserX;
                    btuser3 = "No hay " + btuserX;
                    btuser4 = "No hay " + btuserX;
                    break;
                case 1:
                    btuser1 = Connection.getData(Query).Rows[0][btuserX].ToString();
                    btuser2 = "No hay " + btuserX;
                    btuser3 = "No hay " + btuserX;
                    btuser4 = "No hay " + btuserX;
                    break;
                case 2:
                    btuser1 = Connection.getData(Query).Rows[0][btuserX].ToString();
                    btuser2 = Connection.getData(Query).Rows[1][btuserX].ToString();
                    btuser3 = "No hay " + btuserX;
                    btuser4 = "No hay " + btuserX;
                    break;
                case 3:
                    btuser1 = Connection.getData(Query).Rows[0][btuserX].ToString();
                    btuser2 = Connection.getData(Query).Rows[1][btuserX].ToString();
                    btuser3 = Connection.getData(Query).Rows[2][btuserX].ToString();
                    btuser4 = "No hay " + btuserX;
                    break;
                case 4:
                    btuser1 = Connection.getData(Query).Rows[0][btuserX].ToString();
                    btuser2 = Connection.getData(Query).Rows[1][btuserX].ToString();
                    btuser3 = Connection.getData(Query).Rows[2][btuserX].ToString();
                    btuser4 = Connection.getData(Query).Rows[3][btuserX].ToString();
                    break;
            }
        }

        private void llenarDataGrid()
        {
            Query = "select dv.idCompra as Folio, Pv.Proveedor, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago, U.Usuario from Compra as C, MPago as mp, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;";
            dgvCapCompra.DataSource = Connection.getData(Query);
        }
        private void RegistroCompra(string Proveedor, string Usuario, string fecha, string Producto, int Unidad, string MPago)
        {
            try
            {
                Query = "exec RegistroCompra '" + Proveedor + "','" + Usuario + "','" + fecha + "','" + Producto + "'," + Unidad + ",'" + MPago + "';";
                Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
                MessageBox.Show(Estado);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
        private void ElimCompra(string Proveedor, string Usuario, string fecha, string Producto, int Unidad, string MPago)
        {

            Query = "exec ElimCompra '" + Proveedor + "','" + Usuario + "','" + fecha + "','" + Producto + "'," + Unidad + ",'" + MPago + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user, nivel);
            H.Show();
            this.Close();
        }

        private void btnCapVentas_Click(object sender, EventArgs e)
        {
            CapturadeVentas CV = new CapturadeVentas(user, nivel);
            CV.Show();
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            RegistroCompra(txtproveedor.Text, user, dtpCompra.Value.ToString("dd-MM-yyyy"), txtproducto.Text, Convert.ToInt32(numericUpDown1.Value),cmbMetPago.Text);
            llenarDataGrid();
        }


        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {
            panel1.Show();
            if (txtproveedor.Text == "")
            {
                panel1.Hide();
            }
            UsuariosBuscar(txtproveedor.Text, 4);
            btnProv1.Text = btuser1;
            btnProv2.Text = btuser2;
            btnProv3.Text = btuser3;
            if (btuser1 == "No hay Proveedor")
            {
                btnProv1.Enabled = false;
            }
            else
            {
                btnProv1.Enabled = true;
            }
            if (btuser2 == "No hay Proveedor")
            {
                btnProv2.Enabled = false;
            }
            else
            {
                btnProv2.Enabled = true;
            }
            if (btuser3 == "No hay Proveedor")
            {
                btnProv3.Enabled = false;
            }
            else
            {
                btnProv3.Enabled = true;
            }
        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            panel2.Show();
            if (txtproducto.Text == "")
            {
                panel2.Hide();
            }
            UsuariosBuscar(txtproducto.Text, 2);
            btnProd1.Text = btuser1;
            btnProd2.Text = btuser2;
            btnProd3.Text = btuser3;
            if (btuser1 == "No hay Producto")
            {
                btnProd1.Enabled = false;
            }
            else
            {
                btnProd1.Enabled = true;
            }
            if (btuser2 == "No hay Producto")
            {
                btnProd2.Enabled = false;
            }
            else
            {
                btnProd2.Enabled = true;
            }
            if (btuser3 == "No hay Producto")
            {
                btnProd3.Enabled = false;
            }
            else
            {
                btnProd3.Enabled = true;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ElimCompra(txtproveedor.Text, user, dtpCompra.Value.ToString("dd-MM-yyyy"), txtproducto.Text, Convert.ToInt32(numericUpDown1.Value),cmbMetPago.Text);
            llenarDataGrid();
        }

        private void btnProv1_Click(object sender, EventArgs e)
        {
            txtproveedor.Text = btnProv1.Text;
            panel1.Hide();
        }

        private void btnProv2_Click(object sender, EventArgs e)
        {
            txtproveedor.Text = btnProv2.Text; panel1.Hide();
        }

        private void btnProv3_Click(object sender, EventArgs e)
        {
            txtproveedor.Text = btnProv3.Text; panel1.Hide();
        }

        private void btnProd1_Click(object sender, EventArgs e)
        {
            txtproducto.Text = btnProd1.Text; panel2.Hide();
        }

        private void btnProd2_Click(object sender, EventArgs e)
        {
            txtproducto.Text = btnProd2.Text; panel2.Hide();
        }

        private void btnProd3_Click(object sender, EventArgs e)
        {
            txtproducto.Text = btnProd3.Text; panel2.Hide();
        }

        private void Llenado_Cmb_Metodo_pago()
        {
            Query = "select IDPago, Pago from MPago";
            cmbMetPago.DataSource = Connection.getData(Query);
            cmbMetPago.DisplayMember = "Pago";
            cmbMetPago.ValueMember = "IDPago";
            cmbMetPago.SelectedIndex = -1;
        }

        private void Captura_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}
