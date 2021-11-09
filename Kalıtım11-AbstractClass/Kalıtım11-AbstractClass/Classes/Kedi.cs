using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım11_AbstractClass.Classes
{
    /// <summary>
    /// Kedi sınıfı Hayvan abstract sınıfından implemente edilmiştir.Abstract oldugu için
    /// Hayvan sınıfında olusturdugumuz yüm abstract memberlar burada override edilecektir.
    /// Yani içleri burada doldurulacaktır.
    /// 
    /// </summary>
    class Kedi : Hayvan
    {
        public override string Ad { get; set; }
        public override string Cins { get; set; }
        public override string Cinsiyet { get; set; }
        public override DateTime DogumTarihi { get; set; }
        public override string Dogum()
        {
             return Ad +","+DogumTarihi.Date + "yılında dogmustur ";
        }

        public override string Beslenme()
        {
            return Ad + "," + DateTime.Now + "yılında beslenmistir ";
        }
        public override string Olum()
        {
            return Ad + "," + "- yılında ölmüştür ";
        }
        /// <summary>
        /// parametreli bir constructor olusturuldu ve parametrelerin içleri dolduruldu.
        /// </summary>
        /// <param name="isim"></param>
        /// <param name="tür"></param>
        /// <param name="_cinsiyet"></param>
        /// <param name="dtarihi"></param>
        public Kedi(string isim,string tür,string _cinsiyet,DateTime dtarihi)
        {
            Ad = isim;
            Cins = tür;
            Cinsiyet = _cinsiyet;
            DogumTarihi = dtarihi;
        }
        /// <summary>
        /// Liste döndüren bir Listele metodu olusturdum ctorda aldığım değerleri
        /// burada Liste olustup bu listeye aktardım
        /// </summary>
        /// <returns></returns>
        public List<object> Listele()
        {
            return new List<object>()
            {
                Ad,Cins,Cinsiyet,DogumTarihi,Dogum(),Beslenme(),Olum()
            };
        }
    }
}
