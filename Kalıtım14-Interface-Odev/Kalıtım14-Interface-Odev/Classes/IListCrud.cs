using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım14_Interface_Odev.Classes
{
    interface IListCrud
    {
        void Ekle(ListBox nesne,object item);
        void Duzenle(ListBox nesne,object item);
        void Sil(ListBox nesne,object item);
      
    }
}
