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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog = NorthWind;Integrated Security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();

        }

        private void UrunListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Urunler", baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["Sonlandi"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            decimal fiyat = decimal.Parse(txtFiyat.Text);
            decimal stok = decimal.Parse(txtStok.Text);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("insert into Urunler (UrunAdi,BirimFiyati,HedefStokDuzeyi)values('{0}',{1},{2})",adi,fiyat,stok);
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
            UrunListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("delete from Urunler where UrunAdi = '{0}'",adi);
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
            UrunListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            decimal fiyat = decimal.Parse(txtFiyat.Text);
            decimal stok = decimal.Parse(txtStok.Text);
            string aranacak = txtAra.Text;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("update Urunler set UrunAdi='{0}',BirimFiyati={1},HedefStokDuzeyi={2} where UrunAdi='{3}'", adi, fiyat, stok,aranacak);
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
            UrunListele();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler frm = new Kategoriler();
            frm.Show();
        }
    }
}
