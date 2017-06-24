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
    public partial class HOME : Form
    {
        public HOME(string user, int lvl)
        {
            InitializeComponent();
            User = user;
            lbusuario.Text = user;
            nivel = lvl;
            if (nivel != 1) 
            {
                pcbRegistrarUsuario.Hide();
            }
        }
        private string User = "";
        private int nivel = 0;

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login Li = new Login();
            Li.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Registro_Usuario RU = new Registro_Usuario(User, nivel);
            RU.Show();
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Captura_Proveedores C = new Captura_Proveedores(User, nivel);
            C.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RegistroClientesYProveedores RCP = new RegistroClientesYProveedores(User, nivel);
            RCP.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reporte_de_Compras RC = new Reporte_de_Compras(User, nivel);
            RC.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
