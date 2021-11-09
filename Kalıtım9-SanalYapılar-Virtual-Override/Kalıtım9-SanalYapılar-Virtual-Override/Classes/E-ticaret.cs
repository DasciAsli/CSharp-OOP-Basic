using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım9_SanalYapılar_Virtual_Override.Classes
{
    /// <summary>
    /// Base Sınıf
    /// </summary>
    class E_ticaret
    {
        public float Satici { get; set; }
        public float Site { get; set; }
        /// <summary>
        /// Hesapla adında virtual bir sanal metod kullandım.
        /// Çünkü ben miras bıraktığım kişilerin isterlerse bu metodu ezebilmelerini istiyorum.
        /// </summary>
        public virtual void Hesapla()
        {
            System.Windows.Forms.MessageBox.Show($"Sitenin karı : {Site-Satici}");
        }
    }
}
