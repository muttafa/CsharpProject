using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindORM.Facade;
using NorthwindORM.Entity;
namespace NorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            Tedarikci t = new Tedarikci();
            dataGridView1.DataSource=  Urunler.Select();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "KategoriID";
            cmbKategoriler.DataSource = Kategoriler.Select();

            cmbTedarikciler.DisplayMember = "SirketAdi";
            cmbTedarikciler.ValueMember = "TedarikciID";
            cmbTedarikciler.DataSource = Tedarikciler.Select();


            dataGridView1.Columns["UrunID"].Visible = false;
            dataGridView1.Columns["TedarikciID"].Visible = false;
            dataGridView1.Columns["KategoriID"].Visible = false;
            dataGridView1.Columns["YeniSatis"].Visible = false;
            dataGridView1.Columns["EnAzYenidenSatisMikatari"].Visible = false;
            dataGridView1.Columns["Sonlandi"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            
            u.UrunAdi = txtAdi.Text;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.HedefStokDuzeyi = Convert.ToInt16(nudStok.Value);
            u.BirimFiyati = Convert.ToInt16(nudFiyat.Value);
            u.BirimdekiMiktar = (nudMiktar.Value).ToString();
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;

            bool sonuc = Urunler.Insert(u);
            try
            {
                if (sonuc)
                {

                    MessageBox.Show("Kayıt Eklenmiştir");

                }
                else
                {
                    MessageBox.Show("Kayıt Edilirken Hata Meydana Geldi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());;
            }
            finally
            {
                dataGridView1.DataSource= Urunler.Select();
            }
          
            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            Urun u = new Urun();
            u.UrunID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
            bool sonuc = Urunler.Delete(u);
            if (true)
            {
                MessageBox.Show("Kayıt Silindi");
                Urunler.Delete(u);
            }
            else
            {
                MessageBox.Show("Kayıt Silinirken Bir Hata Gerçekleştii");
            }
            
            dataGridView1.DataSource= Urunler.Select();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nudFiyat.Text = dataGridView1.CurrentRow.Cells["BirimFiyati"].Value.ToString();
            nudStok.Text = dataGridView1.CurrentRow.Cells["HedefStokDuzeyi"].Value.ToString();
            nudMiktar.Text = dataGridView1.CurrentRow.Cells["BirimdekiMiktar"].Value.ToString();
            cmbKategoriler.SelectedItem = dataGridView1.CurrentRow.Cells["KategoriID"].Value.ToString();
            cmbTedarikciler.SelectedItem = dataGridView1.CurrentRow.Cells["TedarikciID"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
            u.UrunAdi = txtAdi.Text;
            u.KategoriID = (int)cmbKategoriler.SelectedValue;
            u.HedefStokDuzeyi = Convert.ToInt16(nudStok.Value);
            u.BirimFiyati = Convert.ToInt16(nudFiyat.Value);
            u.BirimdekiMiktar = (nudMiktar.Value).ToString();
            u.TedarikciID = (int)cmbTedarikciler.SelectedValue;

            bool sonuc = Urunler.Guncelle(u);
            if (sonuc)
            {
                Urunler.Guncelle(u);
                dataGridView1.DataSource= Urunler.Select();
                MessageBox.Show("Kayıt Guncellendi");
            }
            else
            {
                MessageBox.Show("Kayıt Guncellenirken Hata Meydana Geldi");
            }
        }
    }
}
