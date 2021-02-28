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

namespace Ado.Net
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost;Initial Catalog=Northwind;Integrated Security =true");

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriListele();

        }
  

        private void KategoriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Kategoriler", baglanti);
            baglanti.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["KategoriID"].Visible = false;
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtKadi.Text;
            string aciklama = txtAciklama.Text;

            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("insert into Kategoriler (KategoriAdi,Tanimi)values('{0}','{1}')",adi, aciklama);
            komut.Connection = baglanti;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                komut.ExecuteNonQuery();

            }
            else
            {
                komut.ExecuteNonQuery();
            }
           
            baglanti.Close();
            KategoriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = txtKadi.Text;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("delete from Kategoriler where KategoriAdi = '{0}'", adi);
            komut.Connection = baglanti;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                komut.ExecuteNonQuery();

            }
            else
            {
                komut.ExecuteNonQuery();
            }

            baglanti.Close();
            KategoriListele();

        }
    }
}
