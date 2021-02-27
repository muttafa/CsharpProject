using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleEndexi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy = double.Parse(txtBoy.Text);
            double kilo = double.Parse(txtKilo.Text);

            double index = kilo / (boy * boy);

            if (18<index && index < 25)
            {
                lstSonuc.Items.Add("VKİ niz normaldir");
            }
            else if (25<index && index < 30)
            {
                lstSonuc.Items.Add("Kilolusunuz");
            }
            else if (30<index && index<35)
            {
                lstSonuc.Items.Add("Obezsiniz");
            }
            else
            {
                lstSonuc.Items.Add("Doktora görünmelisiniz...");
            }


      
        }
    }
}
