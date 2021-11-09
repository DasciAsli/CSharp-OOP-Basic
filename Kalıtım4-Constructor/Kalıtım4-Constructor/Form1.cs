using Kalıtım4_Constructor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım4_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Her butona tıklandığında listenin temizlenmesi için metod oluşturuldu
        /// </summary>
        public void temizle()
        {
            listListele.Items.Clear();
            arabaListem.Clear();
        }


        /// <summary>
        /// Members sınıfında dizi parametreli bir constructor oluşturuldu
        /// </summary>
        string[] üyeListem = new string[3];
        private void btnDiziCons_Click(object sender, EventArgs e)
        {
            temizle();
            Members üye = new Members(üyeListem);
            foreach (var item in üyeListem)
            {
                listListele.Items.Add(item);
            }
        }


        /// <summary>
        /// Cars sınıfında liste parametreli bir constructor oluşturuldu
        /// </summary>
        List<object> arabaListem = new List<object>();
        private void btnListeCons_Click(object sender, EventArgs e)
        {
            temizle();
            Cars araba = new Cars(arabaListem);
            foreach (var item in arabaListem)
            {
                listListele.Items.Add(item);
            }
        }


    }
}
