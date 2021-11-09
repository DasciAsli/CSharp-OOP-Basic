using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım4_Constructor.Classes
{
    class Cars
    {
        List<object> arabaListesi = new List<object>();
        public Cars(List<object> liste)
        {
            arabaListesi = liste;
            liste.Add("Hyundai");
            liste.Add("Mercedes");
            liste.Add("Audi");
            liste.Add("Bmw");
        }
    }
}
