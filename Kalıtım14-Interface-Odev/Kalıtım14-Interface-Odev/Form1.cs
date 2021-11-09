using Kalıtım14_Interface_Odev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım14_Interface_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Islemler eklemeIslemi = new Islemler();
            eklemeIslemi.Ekle(listListele, txtEkle.Text);
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Islemler duzenleIslemi = new Islemler();
            duzenleIslemi.Duzenle(listListele, txtDuzenle.Text);
        }

        private void listListele_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtDuzenle.Text = listListele.SelectedItem.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Islemler silmeIslemi = new Islemler();
            silmeIslemi.Sil(listListele, txtDuzenle.Text);
        }
    }
}
