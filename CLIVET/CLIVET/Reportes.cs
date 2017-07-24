using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CLIVET
{
    public partial class Reportes : Form
    {
        public Reportes(string user, int lvl)
        {
            User = user;
            nivel = lvl;
            InitializeComponent();
            Llenado_Cmb_Clientes();
            Llenado_Cmb_Proveedores();
        }
        private string User = "";
        private int nivel = 0;
        private string query = "";

        private void btnRepProveedores_Click(object sender, EventArgs e)
        {
            query = "exec RPPROVEEDOR";
            Visualizador_de_Reportes frmRep = new Visualizador_de_Reportes();
            RPproveedores rep1 = new RPproveedores();
            rep1.SetDataSource(Connection.getData(query));
            frmRep.ReportExporta = rep1;
            frmRep.ShowDialog();
            frmRep.Focus();
        }

        private void btnRepClientes_Click(object sender, EventArgs e)
        {
            query = "exec RPPROVEEDOR";
            Visualizador_de_Reportes frmRep = new Visualizador_de_Reportes();
            rpclientes rep1 = new rpclientes();
            rep1.SetDataSource(Connection.getData(query));
            frmRep.ReportExporta = rep1;
            frmRep.ShowDialog();
            frmRep.Focus();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME h = new HOME(User, nivel);
            h.Show();
            this.Close();
        }

        private void btn_Prov_rep_Click(object sender, EventArgs e)
        {
            if (cmbProv.Text != "")
            {
                query = "Busqueda_Compras_a_Proveedor '" + cmbProv.Text + "'";
                Visualizador_de_Reportes frmRep = new Visualizador_de_Reportes();
                RP_Compras_Proveedor rep1 = new RP_Compras_Proveedor();
                rep1.SetDataSource(Connection.getData(query));
                frmRep.ReportExporta = rep1;
                frmRep.ShowDialog();
                frmRep.Focus();
            }
            else
            {
                MessageBox.Show("Es Necesario Seleccionar un Proveedor");
            }
        }

        private void btn_Cliente_rep_Click(object sender, EventArgs e)
        {
            if (cmbCli.Text != "")
            {
                query = "Busqueda_Ventas_a_Cliente '" + cmbCli.Text + "'";
                Visualizador_de_Reportes frmRep = new Visualizador_de_Reportes();
                RP_Ventas_Cliente rep1 = new RP_Ventas_Cliente();
                rep1.SetDataSource(Connection.getData(query));
                frmRep.ReportExporta = rep1;
                frmRep.ShowDialog();
                frmRep.Focus();
            }
            else {
                MessageBox.Show("Es Necesario Seleccionar un Cliente");
            }
        }
        private void Llenado_Cmb_Proveedores()
        {
            query = "Select Proveedor from Proveedor where Proveedor is not null and Proveedor != '' and Proveedor != ' ' and Proveedor != 'NULL'";
            cmbProv.DataSource = Connection.getData(query);
            cmbProv.DisplayMember = "Proveedor";
            cmbProv.SelectedIndex = -1;
        }
        private void Llenado_Cmb_Clientes()
        {
            query = "Select Cliente from Cliente";
            cmbCli.DataSource = Connection.getData(query);
            cmbCli.DisplayMember = "Cliente";
            cmbCli.SelectedIndex = -1;
        }

    }
}
