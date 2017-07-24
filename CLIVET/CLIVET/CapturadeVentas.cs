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
    public partial class CapturadeVentas : Form
    {
        public CapturadeVentas(string User, int lvl)
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


        private string Query = "";
        private string Estado= "";
        private string user = "";
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

        private void RegistroVenta(string Cliente, string Usuario, string fecha, string Producto, int Unidad, string Pago)
        {
            try {
                Query = "exec RegistroVenta '" + Cliente + "', '" + Usuario + "','" + fecha + "','" + Producto + "'," + Unidad + ",'"+Pago+"';";
                Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
                MessageBox.Show(Estado);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
        private void ElimVenta(string Cliente, string Usuario, string fecha, string Producto, int Unidad, string Pago)
        {
            
                Query = "exec ElimVenta '" + Cliente + "', '" + Usuario + "','" + fecha + "','" + Producto + "'," + Unidad + ",'" + Pago + "';";
                Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
                MessageBox.Show(Estado);
            
        }

        private void llenarDataGrid()
        {
            Query = "select dv.idVenta as Folio, C.Cliente, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago, U.Usuario from Venta as V, MPago as mp, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago;";
            dgvCapVenta.DataSource= Connection.getData(Query);

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user, nivel);
            H.Show();
            this.Close();
        }


        private void btnCapCompras_Click(object sender, EventArgs e)
        {
            Captura_Proveedores CC = new Captura_Proveedores(user, nivel);
            CC.Show();
            this.Close();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {            
            RegistroVenta(txtcliente.Text, user, dtpVentas.Value.ToString("dd-MM-yyyy"), txtproducto.Text, Convert.ToInt32(numericUpDown1.Value),cmbMetPago.Text);
            llenarDataGrid();
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            panel1.Show();
            if (txtcliente.Text == "")
            {
                panel1.Hide();
            }
            UsuariosBuscar(txtcliente.Text, 1);
            btnProv1.Text = btuser1;
            btnProv2.Text = btuser2;
            btnProv3.Text = btuser3;
            if (btuser1 == "No hay Cliente")
            {
                btnProv1.Enabled = false;
            }
            else
            {
                btnProv1.Enabled = true;
            }
            if (btuser2 == "No hay Cliente")
            {
                btnProv2.Enabled = false;
            }
            else
            {
                btnProv2.Enabled = true;
            }
            if (btuser3 == "No hay Cliente")
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

        private void txtMetPago_TextAlignChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ElimVenta(txtcliente.Text, user, dtpVentas.Value.ToString("dd-MM-yyyy"), txtproducto.Text, Convert.ToInt32(numericUpDown1.Value), cmbMetPago.Text);
            llenarDataGrid();
        }

        private void btnProv1_Click(object sender, EventArgs e)
        {
            txtcliente.Text = btnProv1.Text; panel1.Hide();
        }

        private void btnProv2_Click(object sender, EventArgs e)
        {
            txtcliente.Text = btnProv2.Text; panel1.Hide();
        }

        private void btnProv3_Click(object sender, EventArgs e)
        {
            txtcliente.Text = btnProv3.Text; panel1.Hide();
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


    }
}



/*string time = dtpVentas.Value.Date.ToString();
DateTime myDateTime = DateTime.Now;
string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
MessageBox.Show(sqlFormattedDate);
MessageBox.Show(time);*/
