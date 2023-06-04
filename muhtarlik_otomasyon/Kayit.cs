using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhtarlik_otomasyon
{
    public partial class Kayit : Form
    {
        private SqlCommand cmd;

        public Kayit()
        {
            InitializeComponent();
            Veritabanı.Gridoldur(dataGridView1,"select *from giris");
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[0].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string ssql = "select *from giris where k_adi='" + textBox1.Text + "'";
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre Girin.");
                }
                else
                {
                    if (Veritabanı.Sorgu(ssql) == false)
                    {
                        //string a = "insert into giris(k_adi,sifre) values ('" + textBox1.Text + "','" + Veritabanı.MD5(textBox2.Text) + "')";
                        //Veritabanı.Komut(a);
                        cmd = new SqlCommand();
                        string sorgu = "insert into giris(k_adi,sifre)values(@k,@sifre)";
                        cmd.Parameters.AddWithValue("@k", textBox1.Text);
                        cmd.Parameters.AddWithValue("@sifre", Veritabanı.MD5(textBox2.Text));
                        Veritabanı.KomutParametre(sorgu, cmd);
                        Veritabanı.Gridoldur(dataGridView1, "select*from giris");
                    }
                    else
                    {
                        MessageBox.Show("Aynı İsimde Kullanıcı Vardır.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                string sorgu = "delete from giris where k_adi='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'";
                Veritabanı.Komut(sorgu);
                Veritabanı.Gridoldur(dataGridView1, "select*from giris");
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir s=new SifreDegistir();
            s.ShowDialog();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void üyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                Uyeler a=new Uyeler();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }

            
        }

        private void işlemlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                İşlemler a=new İşlemler();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void ikametgahİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                İkametgah a=new İkametgah();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void vatandaşAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                Arama a=new Arama();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void vatandaşRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                VatandaşRapor r = new VatandaşRapor();
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.");
            }
            
        }

        private void ikametgahRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Giris.kullanicises == "cihan")
            {
                DetaylıArama d=new DetaylıArama();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu İşlem İçin Yetkiniz Yok.Lütfen tekrar deneyiniz!");
            }
        }
    }
}
