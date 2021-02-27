using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnListele_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db.Urunlers.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.BirimFiyati = Convert.ToInt16(txtBirimFiyati.Text);
            urun.BirimdekiMiktar = txtMiktar.Text;
            urun.HedefStokDuzeyi = Convert.ToInt16(txtStok.Text);
            db.Urunlers.InsertOnSubmit(urun);
            db.SubmitChanges();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var urun = db.Urunlers.First(x => x.UrunAdi == (txtUrunAdi.Text));
            db.Urunlers.DeleteOnSubmit(urun);
            db.SubmitChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = db.Urunlers.First(x => x.UrunID == int.Parse(txtID.Text));
            urun.UrunAdi = txtUrunAdi.Text;
            urun.BirimdekiMiktar = txtMiktar.Text;
            urun.BirimFiyati = Convert.ToInt16(txtBirimFiyati.Text);
            urun.HedefStokDuzeyi = Convert.ToInt16(txtStok.Text);
           
            db.SubmitChanges();
        }
    }
}
