using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public class Product:ICloneable
    {
        public string name { set; get; }//название
        public int price { set; get; }//цена продажи
        public int purchasePrice { set; get; }//цена закупки
        public int number { set; get; }//кол-во на складе
        public Product()
        {
            name = null;
        }
        public Product(string name, int price, int purchasePrice, int number)
        {
            this.name = name;
            this.price = price;
            this.purchasePrice = purchasePrice;
            this.number = number;
        }
        public override string ToString()
        {
            return name+" цена продажи"+price+ " цена закупки "+ purchasePrice+ " на складе "+ number;
        }
        public object Clone()
        {
            return new Product
            {
                name = this.name,
                price = this.price,
                purchasePrice = this.purchasePrice,
                number = this.number
            };
        }
    }
}
