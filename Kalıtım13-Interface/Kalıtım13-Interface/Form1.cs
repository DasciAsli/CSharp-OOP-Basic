using Kalıtım13_Interface.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım13_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCagir_Click(object sender, EventArgs e)
        {
            Bilgisayar bilgisayar1 = new Bilgisayar();
            bilgisayar1.ProductName = "Hp";
            bilgisayar1.Ekle();
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            Telefon tel1 = new Telefon();
            tel1.Ekle("Nokia-3310");
        }
    }
}
