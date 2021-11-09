using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım9_SanalYapılar_Virtual_Override.Classes
{
    class n11 :E_ticaret
    {
        public float Indırım { get; set; }
        /// <summary>
        /// Override kullanarak base sınıfımdaki virtual metodu eziyorum.
        /// </summary>
        public override void Hesapla()
        {
            System.Windows.Forms.MessageBox.Show($"Sitenin kari :{Site-Satici-Indırım}");
        }
    }
}
