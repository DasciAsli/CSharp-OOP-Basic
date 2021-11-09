using Kalitim1_SinifOlusturma_Field.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim1_SinifOlusturma_Field
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnField_Click(object sender, EventArgs e)
        {
            Products ürün1 = new Products();
            ürün1.Listele();
        }
    }
}
