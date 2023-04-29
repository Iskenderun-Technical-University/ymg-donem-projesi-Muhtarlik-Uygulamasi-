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

namespace muhtarlik_otomasyon
{
    public partial class VatandaşRapor : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";


        public void rapordoldur(string sql)
        {
            con= new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            rapor1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = rapor1;
            con.Close();

        }

        public VatandaşRapor()
        {
            InitializeComponent();
        }
        public string a = Giris.kullanicises;
        private void VatandaşRapor_Load(object sender, EventArgs e)
        {
            

            rapordoldur("select * from vatandas where vAd='"+a+"'");
        }
    }
}
