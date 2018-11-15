using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.IO;

namespace laba6
{
    [Serializable]
    public class Market 
    {
        public HashSet<Product> productsSet{ get; set; }
        public long currentAmount;
        public int buyers;
        public Market()
        {
            productsSet = new HashSet<Product>();
            productsSet.Add(new Product("1", 12, 10, 100));
            productsSet.Add(new Product("2", 12, 10, 100));
            productsSet.Add(new Product("3", 12, 10, 100));
            productsSet.Add(new Product("4", 12, 10, 100));
            productsSet.Add(new Product("5", 12, 10, 100));
        }
        public Market(Market market)
        {
            this.productsSet = new HashSet<Product>();
            foreach(Product product in market.productsSet)
            { this.productsSet.Add((Product)product.Clone()); }
            this.currentAmount = market.currentAmount;
            this.buyers = market.buyers;
        }
        public void doTrading()
        {
            while (true)
            {
                Random random = new Random();
                int newBuyers = random.Next(15);
                buyers += newBuyers;
                for (int i =0; i<newBuyers;i++)
                {
                    Buyer buyer = new Buyer();
                    currentAmount += buyer.buy(productsSet);
                }
                Thread.Sleep(500);
            }
        }
        public void doPurchase()
        {
            foreach (Product product in productsSet)
            {
                if (currentAmount > ((10000 - product.number) * product.purchasePrice))
                    {
                        product.number = 10000;
                    currentAmount -= (10000 - product.number) * product.purchasePrice;
                    }
                else
                {
                    int buy = (int)(currentAmount/ product.purchasePrice);
                    currentAmount -= buy * product.purchasePrice;
                    product.number += buy;
                }
                Thread.Sleep(2500);
            }
        }
        
    }
}