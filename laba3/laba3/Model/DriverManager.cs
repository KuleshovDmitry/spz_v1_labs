using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class DriverManager
    {
        public Dictionary<string, Driver> driverMap { get; private set; }
            = new Dictionary<string, Driver>();
        public List<Device> deviceList { get; private set; }
            = new List<Device>() ;
        public int inactiveDevice { get; private set; }
        private Device[] necessaryDevices = new Device[5];
               
        public void instalDriver(Device device, Driver driver)
        {
            device.changeDriver(driver);
        }
        public void addDevice(Device device)
        {
            deviceList.Add(device);
            if ((int)device.typeDevice<5)
            {
                necessaryDevices[(int)device.typeDevice] = device;
            }
        }

        public void deleteDriver(Driver driver)
        {
           driverMap.Remove(driver.name);
        }
       
        public void deleteDevice(Device device)
        {
            deviceList.Remove(device);
        }
        public bool equalsDriver(Driver driverFirst, Driver driverSecond)
        {
            return driverFirst == driverSecond;
        }
        
        public void createRandomDriver(int rndValue)
        {
            if (!driverMap.Keys.Contains(rndValue.ToString()))
            {
                Driver nDriver = new Driver(rndValue.ToString(), (EnumDeviceType)(rndValue % 4), rndValue);

                driverMap.Add(nDriver.name, nDriver);
            }
        }
        public void addDriver(Driver driver)
        {
            
            driverMap.Add(driver.name,driver);
        }
        public bool isReady()
        {
            try
            {
                foreach (Device deviceIt in necessaryDevices)
                {
                    if (!(deviceIt.isReady()))
                    return false;
                }
                return true;
            }
            catch { return false; }
       }


    }
}
