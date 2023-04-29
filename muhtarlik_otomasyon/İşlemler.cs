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
    public partial class İşlemler : Form
    {
        public string seçilen;

        public İşlemler()
        {

            InitializeComponent();
        }
        private void İşlemler_Load(object sender, EventArgs e)
        {
            Veritabanı.Gridoldur(dataGridView1, "select *from vatandas");
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Telefon No";
            dataGridView1.Columns[4].HeaderText = "TC No";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();        
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string sorgu = "select *from vatandas where vTC='" + maskedTextBox2.Text + "'";
                if (textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "")
                {
                    MessageBox.Show("Bilgileri Eksiksiz Girin.");
                }
                else
                {
                    if (Veritabanı.Sorgu(sorgu) == false)
                    {
                        string a = "insert into vatandas(vAd,vSoyad,vTelefon,vTC) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "')";
                        Veritabanı.Komut(a);
                        Veritabanı.Gridoldur(dataGridView1, "select*from vatandas");
                    }
                    else
                    {
                        MessageBox.Show("Vatandaş Zaten Kayıtlı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string sorgu = "delete from vatandas where vTC='" + maskedTextBox2.Text + "'";
                Veritabanı.Komut(sorgu);
                Veritabanı.Gridoldur(dataGridView1, "select *from vatandas");
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string sorgu = "update vatandas set vTelefon='" + maskedTextBox1.Text + "' where vTC='" + maskedTextBox2.Text + "'";
                Veritabanı.Komut(sorgu);
                Veritabanı.Gridoldur(dataGridView1, "select*from vatandas");
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "";
            if (textBox1.Text != "")
            {
                sorgu = "select *from vatandas where vAd like '%" + textBox1.Text + "%'";
                Veritabanı.Gridoldur(dataGridView1,sorgu);
            }
            else
            {
                Veritabanı.Gridoldur(dataGridView1, "select*from vatandas");
            }
        }
    }
}
