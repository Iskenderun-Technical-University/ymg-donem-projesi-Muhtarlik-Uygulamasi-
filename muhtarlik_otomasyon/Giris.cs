using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhtarlik_otomasyon
{
    public partial class Giris : Form
    {
    public Giris()
        {
            InitializeComponent();
            //if (Veritabanı.BaglantiDurum()==true)
            //{
            //    MessageBox.Show("Bağlantı Başarılı.");
            //}
            
        }
        public static string kullanicises = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if(Veritabanı.Giriş(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Giriş Başarılı.");
                kullanicises = textBox1.Text;
                Kayit kyt = new Kayit();
                kyt.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Giriniz.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.");
            }

            
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
