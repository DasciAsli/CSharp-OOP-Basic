using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım13_Interface.Classes
{
    class Telefon : IParametreliCrud
    {
        public void Ekle(string name)
        {
            System.Windows.Forms.MessageBox.Show($"{name} eklendi");
        }
        public void Düzenle(string name)
        {
            System.Windows.Forms.MessageBox.Show($"{name} düzenlendi");
        }

        public void Sil(string name)
        {
            System.Windows.Forms.MessageBox.Show($"{name} silindi");
        }
    }
}
