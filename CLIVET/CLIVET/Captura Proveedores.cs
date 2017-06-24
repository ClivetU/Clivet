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
            lvl = nivel;
            llenarDataGrid();
        }
        private string user = "";
        private string Query = "";
        private string Estado = "";
        private int nivel = 0;
        private void llenarDataGrid()
        {
            Query = "select C.idCompra, Pv.Proveedor, U.Usuario, C.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal from Compra as C, Proveedor as Pv, Usuario as U, detalleCompra as dv, Producto as P where C.idProveedor=Pv.idProveedor and C.idUsuario=U.idUsuario and C.idCompra = dv.idCompra and dv.idProducto=P.idProducto;";
            dgvCapCompra.DataSource = Connection.getData(Query);

        }
        private void RegistroCompra(string Proveedor, string Usuario, DateTime fecha, string Producto, int Unidad)
        {
            Query = "exec RegistroCompra '" + Proveedor + "', '" + Usuario + "','" + fecha + "','" + Producto + "','" + Unidad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user,nivel);
            H.Show();
            this.Close();
        }

        private void btnCapVentas_Click(object sender, EventArgs e)
        {
            CapturadeVentas CV = new CapturadeVentas(user,nivel);
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
            RegistroCompra(txtproveedor.Text, user, dtpCompra.Value, txtproducto.Text, Convert.ToInt32(numericUpDown1.ToString()));
            llenarDataGrid();
        }
    }
}
