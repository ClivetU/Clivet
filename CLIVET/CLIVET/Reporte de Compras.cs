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
    public partial class Reporte_de_Compras : Form
    {
        public Reporte_de_Compras(string User, int lvl)
        {
            InitializeComponent();
            user = User;
            lbusuario.Text = user;
            nivel = lvl;
            llenarDataGrid(txtbusqueda.Text, cmbfiltro.Text);
            cmbfiltro.SelectedItem = "Todo";
        }
        private string user = "";
        private string Query = "";
        private int nivel = 0;

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user,nivel);
            H.Show();
            this.Close();
        }
        private void llenarDataGrid(string busc, string filt)
        {
            Query = "select C.idCompra, Pv.Proveedor, U.Usuario, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal, mp.Pago as Metodo_Pago from Compra as C, MPago as mp, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto and dv.MetodoPAgo=mp.idPago";            
            switch (filt)
            {                
                case "Proveedor":
                    if (busc != "")
                    {
                        Query = Query + " and Pv.Proveedor like '"+busc+"%'";
                    }
                    Query = Query + " order by Pv.Proveedor asc;";
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
                        Query = Query + " and C.fecha like '" + busc + "%'";
                    }
                    Query = Query + " order by C.fecha asc;";
                    break;
                default:
                    if (txtbusqueda.Text != "")
                        MessageBox.Show("Si se selecciona 'Todo', no se hace uso de la busqueda");
                    txtbusqueda.Text = "";
                    break;
            }

            DataGridView1.DataSource = Connection.getData(Query);
        }

        private void btnCapCompras_Click(object sender, EventArgs e)
        {
            Form1 RV = new Form1(user,nivel);
            RV.Show();
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            llenarDataGrid(txtbusqueda.Text, cmbfiltro.Text);
        }

        private void cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.Text == "Todo")
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
