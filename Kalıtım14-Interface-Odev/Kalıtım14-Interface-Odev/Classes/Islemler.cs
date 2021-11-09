using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım14_Interface_Odev.Classes
{
    class Islemler : IListCrud
    {
        public void Ekle(ListBox nesne, object item)
        {
            nesne.Items.Add(item);
        }
        public void Duzenle(ListBox nesne, object item)
        {
            int id = nesne.SelectedIndex;
            nesne.Items.RemoveAt(id);
            nesne.Items.Insert(id, item);
        }
        public void Sil(ListBox nesne, object item)
        {
            nesne.Items.RemoveAt(nesne.SelectedIndex);
        }
    }
}
