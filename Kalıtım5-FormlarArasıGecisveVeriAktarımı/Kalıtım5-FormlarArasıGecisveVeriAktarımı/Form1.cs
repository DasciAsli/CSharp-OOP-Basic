using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım5_FormlarArasıGecisveVeriAktarımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<object> f2dengelen = new List<object>();
        public Form1(List<object> gelen)
        {
            InitializeComponent();
            f2dengelen = gelen;
        }
        List<object> arabaListem = new List<object>();
        private void btnListele_Click(object sender, EventArgs e)
        {
            listListele.Items.Clear();        
            Cars araba = new Cars(arabaListem);
            foreach (var item in arabaListem)
            {
                listListele.Items.Add(item);
            }
        }

        private void btnGecis_Click(object sender, EventArgs e)
        {
            Form2 sayfa2 = new Form2(arabaListem);
            sayfa2.Show();
            this.Hide();
        }

        private void btnGelen_Click(object sender, EventArgs e)
        {
            foreach (var item in f2dengelen)
            {
                listListele.Items.Add(item);
            }
        }
    }
}
