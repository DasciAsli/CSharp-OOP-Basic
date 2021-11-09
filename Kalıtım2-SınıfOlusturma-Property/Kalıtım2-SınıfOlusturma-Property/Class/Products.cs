using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım2_SınıfOlusturma_Property.Class
{
    class Products
    {
        //Fieldlar
        int productId;
        string productName;
        int stockAmount;
        float price;

        //Propertyler
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int StockAmount { get; set; }
        public float Price { get; set; }

        public void Listele()
        {
            System.Windows.Forms.MessageBox.Show
                (
                "Ürün Id :" + ProductId + "\n" +
                "Ürün Ad :" + ProductName + "\n" +
                "Ürün Stok :" + StockAmount + "\n" +
                "Ürün Fiyat :" + Price + "\n" 
                );
        }

    }
}
