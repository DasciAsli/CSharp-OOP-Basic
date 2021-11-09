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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        List<object> f1dengelen = new List<object>();
        public Form2(List<object> gelen)
        {
            InitializeComponent();
            f1dengelen = gelen;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            foreach (var item in f1dengelen)
            {
                listGoster.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listGoster.Items.Add(textBox1.Text);
        }

        private void listGoster_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listGoster.SelectedItem.ToString();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id = listGoster.SelectedIndex;
            listGoster.Items.RemoveAt(id);
            listGoster.Items.Insert(id, textBox1.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listGoster.Items.RemoveAt(listGoster.SelectedIndex);
        }

        List<object> aktarımListesi = new List<object>();
        private void btnAktar_Click(object sender, EventArgs e)
        {
            foreach (var item in listGoster.Items)
            {
                aktarımListesi.Add(item);
            }
            Form1 x = new Form1(aktarımListesi);
            x.Show();
            this.Hide();
        }
    }
}
