using BillingSystem.BLL;
using BillingSystem.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BillingSystem.UI
{
    public partial class frmGraph : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public frmGraph()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "select distinct(p_name) , sum(price) from tbl_show where date between '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' group by p_name";
            String[] name = new String[100];
            decimal[] price = new decimal[100];
            int cur = 0;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            string nam = "";
            string tot = "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                nam = dr.GetValue(0).ToString();
                tot = dr.GetValue(1).ToString();
                name[cur] = nam;
                price[cur] = decimal.Parse(tot);
                cur++;
            }

            con.Close();

            for(int i = 0; i < cur; i++)
            {
                this.chart1.Series["Item"].Points.AddXY(name[i], price[i]);
            }
        }
    }
}
