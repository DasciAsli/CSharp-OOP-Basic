using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım5_FormlarArasıGecisveVeriAktarımı
{
    class Cars
    {
        List<object> arabaListesi = new List<object>();
        public Cars(List<object> liste)
        {
            arabaListesi = liste;
            liste.Add("Mercedes");
            liste.Add("Tofaş");
            liste.Add("Serçe");
            liste.Add("Şahin");
        }
    }
}
