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
    public partial class İkametgah : Form
    {
        public İkametgah()
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
            da.Fill(ds, "vatandas");
            dataGridView1.DataSource = ds.Tables["vatandas"];
            con.Close();
        }

        private void İkametgah_Load(object sender, EventArgs e)
        {

            string sorgu = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
            Veritabanı.Gridoldur(dataGridView1,sorgu);

            dataGridView1.Columns[0].HeaderText = "İkametgah ID";
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
        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ikametgah where ikametgah_ID='" + textBox6.Text + "'";
            Veritabanı.Komut(sorgu);
            string sorgu2 = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
            Veritabanı.Gridoldur(dataGridView1, sorgu2);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            İşlemler asd = new İşlemler();

            //textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text=asd.seçilen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string sorgu = "select *from vatandas where vTC='" + textBox5.Text + "'";
                string sorgu2 = "select *from ikametgah where vTC='" + textBox5.Text + "'";

                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Bilgileri Eksiksiz Girin.");
                }
                else
                {
                    if (Veritabanı.Sorgu(sorgu) == true && Veritabanı.Sorgu(sorgu2) == false) 
                    {
                        string a = "insert into ikametgah(i_sokak,i_NO,i_daire,vTC) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                        Veritabanı.Komut(a);
                        string sorgu3 = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
                        Veritabanı.Gridoldur(dataGridView1, sorgu3);
                    }
                    else if(Veritabanı.Sorgu(sorgu2) == true)
                    {
                        MessageBox.Show("Vatandaşın İkametgah Bilgisi Kayıtlı.");
                    }
                    else
                    {
                        MessageBox.Show("Vatandaş Bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Bilgileri Eksiksiz Girin.");
            }
            else
            {
                string sorgu = "update ikametgah set i_sokak='" + textBox2.Text + "', i_NO='" + textBox3.Text + "', i_daire='" + textBox4.Text + "'where vTC='" + textBox5.Text + "'";
                Veritabanı.Komut(sorgu);

                string sorgu3 = "select ikametgah.*, vatandas.* from ikametgah INNER JOIN vatandas ON ikametgah.vTC=vatandas.vTC";
                Veritabanı.Gridoldur(dataGridView1, sorgu3);
            }

        }
    }
}
