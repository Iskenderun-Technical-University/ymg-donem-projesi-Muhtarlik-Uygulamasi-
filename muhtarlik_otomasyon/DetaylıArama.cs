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
    public partial class DetaylıArama : Form
    {
        public DetaylıArama()
        {
            InitializeComponent();
        }



        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";

        void doldur(string sorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }



        private void DetaylıArama_Load(object sender, EventArgs e)
        {
            string sorgu = "select ikametgah.*,vatandas.vAd,vatandas.vSoyad,vatandas.vTelefon from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
            doldur(sorgu);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Sokak";
            dataGridView1.Columns[2].HeaderText = "NO";
            dataGridView1.Columns[3].HeaderText = "Daire";
            dataGridView1.Columns[4].HeaderText = "TC NO";
            dataGridView1.Columns[5].HeaderText = "Ad";
            dataGridView1.Columns[6].HeaderText = "Soyad";
            dataGridView1.Columns[7].HeaderText = "Telefon";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string sorgu = "select ikametgah.*,vatandas.vAd,vatandas.vSoyad,vatandas.vTelefon from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where ikametgah.i_sokak like '" + textBox1.Text + "'";
                doldur(sorgu);
            }
            else
            {
                string sorgu = "select ikametgah.*,vatandas.vAd,vatandas.vSoyad,vatandas.vTelefon from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
                doldur(sorgu);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporDetay r=new RaporDetay();
            r.sokak = textBox1.Text;
            r.ds = ds;
            r.Show();
        }
    }
}
