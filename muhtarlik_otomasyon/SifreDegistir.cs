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
    public partial class SifreDegistir : Form
    {
        int sonuc = 0;
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";


        public SifreDegistir()
        {
            InitializeComponent();
        }
        public void RandomSayi()
        {
            Random rand = new Random();
            int ilk=rand.Next(0,50);
            int iki=rand.Next(0,50);
            sonuc = ilk + iki;
            label4.Text = ilk.ToString() + "+" + iki.ToString() + "=";
            textBox4.Clear();
        }
        public void Temizle()

        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        public void SifreKontrol()
        {
            string sorgu = "select sifre from giris where k_adi=@a and sifre=@b";

            con = new SqlConnection(SqlCon);
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@a",Giris.kullanicises);
            com.Parameters.AddWithValue("@b", Veritabanı.MD5(textBox1.Text));


            con.Open();
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string sql = "update giris set sifre='" + Veritabanı.MD5(textBox2.Text) + "'where k_adi='"+Giris.kullanicises+"'";
                Veritabanı.Komut(sql);
                MessageBox.Show("Şifreniz Değiştirildi.");
            }
            else
            {
                MessageBox.Show("Eski Şifreniz Hatalı.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox4.Text == sonuc.ToString())
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SifreKontrol();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Yeni Şifre ve Onay Aynı Değil");
                    Temizle();
                    RandomSayi();
                }
            }
            else
            {
                MessageBox.Show("Sonuç Yanlış.");
                Temizle();
                RandomSayi();
            }

        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            RandomSayi();
        }
    }
}
