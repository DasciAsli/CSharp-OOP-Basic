using Kalıtım11_AbstractClass.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım11_AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Kedi kedim = new Kedi(txtIsim.Text,txtCins.Text,txtCinsiyet.Text,dateTimePicker1.Value);
            foreach (var item in kedim.Listele())
            {
                listListele.Items.Add(item);
            }
        }
    }
}
