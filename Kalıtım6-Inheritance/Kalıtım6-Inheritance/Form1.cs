using Kalıtım6_Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım6_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTavuk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Tavuk tavuk1 = new Tavuk("Hilmi", 3, true, "Kırmızı");
            foreach (var item in tavuk1.Listele())
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
