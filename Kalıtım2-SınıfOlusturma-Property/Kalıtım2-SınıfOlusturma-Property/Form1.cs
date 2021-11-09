using Kalıtım2_SınıfOlusturma_Property.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım2_SınıfOlusturma_Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Products ürün = new Products();
            ürün.ProductId = 2;
            ürün.ProductName = "Lenovo";
            ürün.StockAmount = 60;
            ürün.Price = 6000f;
            ürün.Listele();
        }
    }
}
