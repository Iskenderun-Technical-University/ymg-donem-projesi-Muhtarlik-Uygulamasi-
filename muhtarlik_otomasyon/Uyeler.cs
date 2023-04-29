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
    public partial class Uyeler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public static string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";

        public static string sess = "";


        public Uyeler()
        {
            InitializeComponent();
        }

        public void Navigasyon()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select*from giris", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "giris");
            con.Close();

            bindingSource1.DataSource = ds.Tables["giris"];
            bindingNavigator1.BindingSource = bindingSource1;

            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "k_adi"));
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "sifre"));

        }

        private void Uyeler_Load(object sender, EventArgs e)
        {
            Navigasyon();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            string sorgu = "select *from giris where k_adi='" + textBox1.Text + "'";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Girin.");
            }
            else
            {
                if (Veritabanı.Sorgu(sorgu) == false)
                {
                    string a = "insert into giris(k_adi,sifre) values ('" + textBox1.Text + "','" + Veritabanı.MD5(textBox2.Text) + "')";
                    Veritabanı.Komut(a);
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Aynı İsimde Kullanıcı Vardır.");
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            sess = textBox1.Text;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            sess=textBox1.Text;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from giris where k_adi='" + sess + "'";
            Veritabanı.Komut(sorgu);
        }
    }
}
