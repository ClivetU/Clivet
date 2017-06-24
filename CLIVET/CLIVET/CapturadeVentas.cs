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
        }


        private string Query = "";
        private string Estado= "";
        private string user = "";
        private int nivel = 0;

        private void RegistroVenta(string Cliente, string Usuario, string fecha, string Producto, int Unidad)
        {
            Query = "exec RegistroVenta '" + Cliente + "', '" + Usuario + "','" + fecha + "','" + Producto + "','" + Unidad + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void llenarDataGrid()
        {
            Query = "select V.idVenta, C.Cliente, U.Usuario, V.fecha, P.Producto, dv.Cantidad, dv.PrecioTotal from Venta as V, Cliente as C, Usuario as U, detalleVenta as dv, Producto as P where V.idCliente=C.idCliente and V.idUsuario=U.idUsuario and V.idVenta = dv.idVenta and dv.idProducto=P.idProducto;";
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
            RegistroVenta(txtcliente.Text, user, dtpVentas.Value.Date.ToString("yyyy-dd-MM HH:mm:ss.fff"), txtproducto.Text, Convert.ToInt32(numericUpDown1.ToString()));
            llenarDataGrid();
        }
    }
}



/*string time = dtpVentas.Value.Date.ToString();
DateTime myDateTime = DateTime.Now;
string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
MessageBox.Show(sqlFormattedDate);
MessageBox.Show(time);*/
