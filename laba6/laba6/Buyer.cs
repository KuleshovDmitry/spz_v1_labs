using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Buyer
    {
        public int buy(HashSet<Product> productsSet)
        {
            int sum = 0;
            Random random = new Random();
            int buf;
            for (int i =0; i< productsSet.Count;i++)
            {
                buf = random.Next(i);
                int j = i;
                foreach (Product product in productsSet)
                {
                    j += 5;
                    if (random.Next(j) > i)
                    {
                        product.number -= buf % 5;
                        sum += buf % 5 * product.price;
                    }
                }
                
            }
            return sum;
        }

    }
}
