using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows;

namespace CLIVET
{
    public partial class Visualizador_de_Reportes : Form
    {
        internal CrystalDecisions.CrystalReports.Engine.ReportDocument ReportExporta;
        public Visualizador_de_Reportes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = ReportExporta;
        }
    }
}
