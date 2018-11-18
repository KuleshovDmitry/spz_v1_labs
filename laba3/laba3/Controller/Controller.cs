using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public static class Controller
    {
        public static DriverManager driverManager { get; private set; } 
            = new DriverManager();

        public static void genrateRandomDrivers()
        {
            Random rnd = new Random(Environment.TickCount);
            int randomDriverNumber = rnd.Next(1, 10);
            int rndValue;
            for (int i = 0; i < randomDriverNumber; i++)
            {
                rndValue = rnd.Next(0, 48);
                driverManager.createRandomDriver(rndValue);
            }
        }
        public static void changeDriver(Driver oldDriver, Driver newDriver)
        {
            if (!driverManager.driverMap.Keys.Contains(newDriver.name))
            {
                driverManager.addDriver(newDriver);
                if ((Object)oldDriver != null)
                driverManager.driverMap.Remove(oldDriver.name);
            }
            else { MessageBox.Show("драйвер с таким именем присутствует"); }
        }

    }
}
