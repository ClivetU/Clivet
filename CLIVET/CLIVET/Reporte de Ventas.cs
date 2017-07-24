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
    public partial class Form1 : Form
    {
        public Form1(string User, int lvl)
        {
            InitializeComponent();
            user = User;
            lbusuario.Text = user;
            nivel = lvl;
            llenarDataGrid(txtbusqueda.Text, combofiltro.Text);
            combofiltro.SelectedItem = "Todo";
        }
        private string user = "";
        private int nivel = 0;
        private string Query = "";

        private void llenarDataGrid(string busc, string filt)
        {
            Query = "select V.idVenta, C.Cliente, U.Usuario, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago from Venta as V, MPago as mp, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago";
            switch (filt)
            {                
                case "Cliente":
                    if (busc != "")
                    {
                        Query = Query + " and C.Cliente like '" + busc + "%'";
                    }
                    Query = Query + " order by C.Cliente asc;";
                    break;
                case "Usuario":
                    if (busc != "")
                    {
                        Query = Query + " and U.Usuario like '" + busc + "%'";
                    }
                    Query = Query + " order by U.Usuario asc;";
                    break;
                case "Producto":
                    if (busc != "")
                    {
                        Query = Query + " and P.Producto like '" + busc + "%'";
                    }
                    Query = Query + " order by P.Producto asc;";
                    break;
                case "Fecha":
                    if (busc != "")
                    {
                        Query = Query + " and V.fecha like '" + busc + "%'";
                    }
                    Query = Query + " order by V.fecha asc;";
                    break;
                default:
                    if (txtbusqueda.Text != "")
                        MessageBox.Show("Si se selecciona 'Todo', no se hace uso de la busqueda");
                    txtbusqueda.Text = "";
                    break;
            }

            DataGridView1.DataSource = Connection.getData(Query);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbusuario_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbsucursal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user, nivel);
            H.Show();
            this.Close();
        }

        private void btnCapCompras_Click(object sender, EventArgs e)
        {
            Reporte_de_Compras RC = new Reporte_de_Compras(user, nivel);
            RC.Show();
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

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            llenarDataGrid(txtbusqueda.Text, combofiltro.Text);
        }

        private void combofiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofiltro.Text == "Todo")
            {
                txtbusqueda.Text = "";
                txtbusqueda.Enabled = false;
            }
            else
            {
                txtbusqueda.Enabled = true;
            }
        }
    }
}
