using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim1_SinifOlusturma_Field.Class
{
    class Products
    {
        int productId;
        string productName;
        int stockAmount;
        float price;

        public void Listele()
        {
            productId = 1;
            productName = "Asus";
            stockAmount = 50;
            price = 5000f;
            System.Windows.Forms.MessageBox.Show
                (
                "Ürün Id    : " + productId + "\n" +
                "Ürün Ad    : " + productName + "\n" +
                "Ürün Stok  : " + stockAmount + "\n" +
                "Ürün Fiyat : " + price + "\n" 
                );
        }
    }
}
