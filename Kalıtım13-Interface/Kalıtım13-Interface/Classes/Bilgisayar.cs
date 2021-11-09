using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım13_Interface.Classes
{
    class Bilgisayar : IProducts, ICrud
    {
        public int ProductId { get ; set; }
        public string ProductName { get; set; }
        public float Price { get ; set; }
        public void Ekle()
        {
            System.Windows.Forms.MessageBox.Show($"{ProductName} eklendi");
        }

        public void Düzenle()
        {
            System.Windows.Forms.MessageBox.Show($"{ProductName} düzenlendi");
        }

        public void Sil()
        {
            System.Windows.Forms.MessageBox.Show($"{ProductName} silindi");
        }
    }
}
