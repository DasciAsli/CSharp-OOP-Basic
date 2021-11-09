using Kalıtım12_AbstractClass2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım12_AbstractClass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYE_Click(object sender, EventArgs e)
        {
            YüzüklerinEfendisi kitap1 = new YüzüklerinEfendisi();
            kitap1.KitapAd = "Yüzüklerin Efendisi";
            kitap1.KitapYazar = "J R R Tokien";
            foreach (var item in kitap1.Listele())
            {
                listYüzüklerinEfendisi.Items.Add(item);
            }
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            HarryPotter kitap2 = new HarryPotter();
            kitap2.KitapAd = "Harry Potter";
            kitap2.KitapYazar = "J K Rowling";
            foreach (var item in kitap2.Listele())
            {
                listHarryPotter.Items.Add(item);
            }
        }
    }
}
