
namespace Veri_Listeleme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblBirimFiyati = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblHedefStok = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.lblTedarikciler = new System.Windows.Forms.Label();
            this.lblKategoriler = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(862, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(0, 355);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(80, 39);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(0, 400);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 39);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(86, 355);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 39);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(86, 400);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(91, 39);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(341, 354);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(341, 415);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 6;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(341, 384);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtBirimFiyati.TabIndex = 7;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(266, 359);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(71, 17);
            this.lblAdi.TabIndex = 8;
            this.lblAdi.Text = "Urun Adi :";
            // 
            // lblBirimFiyati
            // 
            this.lblBirimFiyati.AutoSize = true;
            this.lblBirimFiyati.Location = new System.Drawing.Point(291, 384);
            this.lblBirimFiyati.Name = "lblBirimFiyati";
            this.lblBirimFiyati.Size = new System.Drawing.Size(46, 17);
            this.lblBirimFiyati.TabIndex = 9;
            this.lblBirimFiyati.Text = "Fiyat :";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(222, 411);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(115, 17);
            this.lblMiktar.TabIndex = 10;
            this.lblMiktar.Text = "Birimdeki Miktar :";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(558, 354);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 22);
            this.txtStok.TabIndex = 11;
            // 
            // lblHedefStok
            // 
            this.lblHedefStok.AutoSize = true;
            this.lblHedefStok.Location = new System.Drawing.Point(461, 355);
            this.lblHedefStok.Name = "lblHedefStok";
            this.lblHedefStok.Size = new System.Drawing.Size(91, 17);
            this.lblHedefStok.TabIndex = 12;
            this.lblHedefStok.Text = "Stok Duzeyi :";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Items.AddRange(new object[] {
            "Beverages",
            "Condiments",
            "Confections",
            "Dairy Urunler",
            "Grains/Cereals",
            "Meat/Poultry",
            "Produce",
            "Seafood"});
            this.cmbKategoriler.Location = new System.Drawing.Point(558, 384);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cmbKategoriler.TabIndex = 13;
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(558, 415);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(121, 24);
            this.cmbTedarikciler.TabIndex = 14;
            // 
            // lblTedarikciler
            // 
            this.lblTedarikciler.AutoSize = true;
            this.lblTedarikciler.Location = new System.Drawing.Point(461, 422);
            this.lblTedarikciler.Name = "lblTedarikciler";
            this.lblTedarikciler.Size = new System.Drawing.Size(90, 17);
            this.lblTedarikciler.TabIndex = 15;
            this.lblTedarikciler.Text = "Tedarikciler :";
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.AutoSize = true;
            this.lblKategoriler.Location = new System.Drawing.Point(461, 387);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(85, 17);
            this.lblKategoriler.TabIndex = 16;
            this.lblKategoriler.Text = "Kategoriler :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(685, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(750, 387);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(723, 390);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 457);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblKategoriler);
            this.Controls.Add(this.lblTedarikciler);
            this.Controls.Add(this.cmbTedarikciler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lblHedefStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBirimFiyati);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblBirimFiyati;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblHedefStok;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ComboBox cmbTedarikciler;
        private System.Windows.Forms.Label lblTedarikciler;
        private System.Windows.Forms.Label lblKategoriler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}

