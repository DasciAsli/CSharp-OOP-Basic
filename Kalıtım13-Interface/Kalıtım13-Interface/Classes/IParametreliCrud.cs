using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım13_Interface.Classes
{

    interface IParametreliCrud
    {
        void Ekle(string name);
        void Düzenle(string name);
        void Sil(string name);

    }
}
