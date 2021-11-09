using Kalıtım9_SanalYapılar_Virtual_Override.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım9_SanalYapılar_Virtual_Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //n11 sınıfında ezdiğim Hesapla metodunu çağırıyorum ve ezilmiş halini kullanıyorum.
            n11 x = new n11();
            x.Site = 1000f;
            x.Satici = 800f;
            x.Indırım = 20f;
            x.Hesapla();

        }
    }
}
