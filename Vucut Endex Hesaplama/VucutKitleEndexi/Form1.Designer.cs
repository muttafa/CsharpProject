
namespace VucutKitleEndexi
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
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoy.Location = new System.Drawing.Point(12, 44);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(116, 29);
            this.lblBoy.TabIndex = 0;
            this.lblBoy.Text = "Boyunuz :";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKilo.Location = new System.Drawing.Point(6, 87);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(122, 29);
            this.lblKilo.TabIndex = 1;
            this.lblKilo.Text = " Kilonuz   :";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(134, 51);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(152, 22);
            this.txtBoy.TabIndex = 2;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(134, 94);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(152, 22);
            this.txtKilo.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(134, 139);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(152, 77);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 16;
            this.lstSonuc.Location = new System.Drawing.Point(74, 263);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(260, 84);
            this.lstSonuc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 448);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstSonuc;
    }
}

