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
        }
        private string user = "";
        private int nivel = 0;

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user,nivel);
            H.Show();
            this.Close();
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
    }
}
