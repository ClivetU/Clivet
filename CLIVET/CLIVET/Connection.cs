using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CLIVET
{
    class Connection
    {
        public static string CnnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CLIVET.Properties.Settings.ConnectionClivet"].ConnectionString;
            }
        }
        public static DataTable getData(string Procedimiento)
        {
            SqlCommand cm = new SqlCommand();
            DataTable dt;
            string CON = ConfigurationManager.ConnectionStrings["CLIVET.Properties.Settings.ConnectionClivet"].ConnectionString;
            //Procedimiento para ejecutar la consulta en SQL
            SqlConnection CN = new SqlConnection(CON);
            cm = new SqlCommand(Procedimiento, CN);
            CN.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            dt = new DataTable();
            adp.Fill(dt);

            CN.Close();
            return dt;

        }
    }
}
