using Kalıtım6_Inheritence2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım6_Inheritence2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKadın_Click(object sender, EventArgs e)
        {
            Kadın kadın1 = new Kadın("Asli", "Dasci", 28, true, "Dasci");
            foreach (var item in kadın1.Listele())
            {
                listListele.Items.Add(item);
            }
        }
    }
}
