﻿using Kalıtım10_Polimorphism.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım10_Polimorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPoly_Click(object sender, EventArgs e)
        {
            Insan asli = new Kadın();
            asli.Ad = "Asli";
            asli.Soyad = "Dasci";
            asli.Yas = 28;
            asli.MedeniHal = true;

            MessageBox.Show("Asli nesnesinin Insan sınıfından işaret edilmesinin sonucunda Insan sınıfındaki fieldlarını kullanabildim.");


            Kadın isik = new Kadın();
            isik.Ad = "Işık";
            isik.Soyad = "fghjkl";
            isik.Yas = 18;
            isik.MedeniHal = true;
            isik.KızlıkSoyadı = "dfghjk";

            MessageBox.Show("isik nesnesinin Kadın sınıfından işaret edilmesinin sonucunda Kadın sınıfındaki fieldlarını kullanabildim");
        }
    }
}
