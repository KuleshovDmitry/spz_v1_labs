using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace laba6
{
    class MarktManager
    {
        private Market market = new Market();
        private List<Market> marketStats = new List<Market>();

        private Thread traidingMode;
        private Thread purchaseMode;
        public long getCurrentAmount()
        {
            return market.currentAmount;
        }
        public void traiding()
        {
            if (traidingMode != null && traidingMode.ThreadState == ThreadState.Running)
                traidingMode.Join();
            purchaseMode = new Thread(market.doPurchase);
            purchaseMode.Start();
        }
        public void purchase()
        {
            if (purchaseMode != null && purchaseMode.ThreadState == ThreadState.Running)
                purchaseMode.Join();
            traidingMode = new Thread(market.doTrading);
            traidingMode.Start();
            marketStats.Add(new Market(market));
            BindingSource binding = new BindingSource();
            using (FileStream file = new FileStream("laba6.xml", FileMode.Create))
            {
                new XmlSerializer(typeof(List<Market>)).Serialize(file, marketStats);
            }
            market.buyers = 0;
        }
        ~MarktManager()
        {
            traidingMode.Abort();
            purchaseMode.Abort();
        }
    }
}
