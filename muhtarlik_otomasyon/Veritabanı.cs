using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;

namespace muhtarlik_otomasyon
{
    internal class Veritabanı
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand com;
        static SqlDataReader dr;
        static System.Data.DataSet ds;

        public static string SqlCon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=muhtarlik;Integrated Security=True";

        public static bool BaglantiDurum()
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }

        public static DataGridView Gridoldur(DataGridView grid, string selsorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(selsorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, selsorgu);

            grid.DataSource = ds.Tables[selsorgu];
            con.Close();
            return grid;
        }

        public static string MD5(string pass)


        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(pass);

            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in dizi)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }

        public static bool Giriş(string kadi, string sifr)
        {
            string sorgu = "select *From giris where k_adi=@a and sifre=@b";

            con = new SqlConnection(SqlCon);
            com = new SqlCommand(sorgu, con);
            com.Parameters.AddWithValue("@a", kadi);
            com.Parameters.AddWithValue("@b", Veritabanı.MD5(sifr));


            con.Open();
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                return true;
                con.Close();
            }
            else
            {
                return false;
                con.Close();
            }
        }

        public static bool Sorgu(string sql)
        {
            con = new SqlConnection(SqlCon);
            SqlCommand sorgu = new SqlCommand(sql,con);
            con.Open();
            dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                return true;
                con.Close();
            }
            else
                return false;
            con.Close();
        }

        public static void Komut(string sorgu)

        {
            con = new SqlConnection(SqlCon);
            com = new SqlCommand(sorgu,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public static void KomutParametre(string sorgu, SqlCommand cmd)
        {
            con=new SqlConnection(SqlCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataGridView doldurprosedur(DataGridView gridim,string prosedürismi, string deger, string tür)
        {
            con = new SqlConnection(SqlCon);
            com = new SqlCommand(prosedürismi, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(tür, SqlDbType.NVarChar, 50).Value = "%" + deger + "%";
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            gridim.DataSource = ds.Tables[0];
            con.Close();
            return gridim;
        }
    }
}