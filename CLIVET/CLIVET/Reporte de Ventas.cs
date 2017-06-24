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
        }
        private string user = "";
        private int nivel = 0;

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
    }
}
