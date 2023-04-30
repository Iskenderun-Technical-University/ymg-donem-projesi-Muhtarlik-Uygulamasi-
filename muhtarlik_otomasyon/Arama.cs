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

namespace muhtarlik_otomasyonss
{
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)
                {
                    //string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where vatandas.vAd like '%" + textBox1.Text + "%'";
                    //doldur(sorgu);
                    Veritabanı.doldurprosedur(dataGridView1,"Yazdırma",textBox1.Text,"vAdı");
                    label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);
                }
                else if (radioButton2.Checked)
                {
                    //string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where vatandas.vSoyad like '%" + textBox1.Text + "%'";
                    //doldur(sorgu);
                    Veritabanı.doldurprosedur(dataGridView1,"YazdırmaSoyad", textBox1.Text, "vSoyad");
                    label3.Text = Convert.ToString(dataGridView1.Rows.Count-1);

                }
                else if (radioButton3.Checked)
                {
                    //string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where vatandas.vTC like '%" + textBox1.Text + "%'";
                    //doldur(sorgu);
                    Veritabanı.doldurprosedur(dataGridView1, "YazdırmaTC", textBox1.Text, "vtC");
                    label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);
                }
                else if (radioButton6.Checked)
                {
                    //string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where ikametgah.i_sokak like '%" + textBox1.Text + "%'";
                    //doldur(sorgu);
                    Veritabanı.doldurprosedur(dataGridView1, "YazdırmaSokak", textBox1.Text, "sokak");
                    label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);
                }
                else if  (radioButton5.Checked)
                {
                    //string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC where ikametgah.i_no like '%" + textBox1.Text + "%'";
                    //doldur(sorgu);
                    Veritabanı.doldurprosedur(dataGridView1, "YazdırmaNO", textBox1.Text, "no");
                    label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);
                }
            }
            else
            {
                string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
                Veritabanı.Gridoldur(dataGridView1,sorgu);
                label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);
            }
        }
        void doldur(string sorgu)
        {
            con=new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds,sorgu);
            dataGridView1.DataSource= ds.Tables[0];
            con.Close();
        }
        private void Arama_Load(object sender, EventArgs e)
        {
            string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
            Veritabanı.Gridoldur(dataGridView1, sorgu);
            label3.Text = Convert.ToString(dataGridView1.Rows.Count - 1);

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Sokak";
            dataGridView1.Columns[2].HeaderText = "Apartman NO";
            dataGridView1.Columns[3].HeaderText = "Daire NO";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Ad";
            dataGridView1.Columns[7].HeaderText = "Soyad";
            dataGridView1.Columns[8].HeaderText = "Telefon";
            dataGridView1.Columns[9].HeaderText = "TC NO";


        }
    }
}
