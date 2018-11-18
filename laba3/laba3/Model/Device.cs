using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public enum EnumDeviceType
    {
        motherboard,
        processor,
        videoCard,
        RAM,
        HDD,
        keyboard,
        mouse,
        flashMemoryCard, 
        CDDVDDrive,
        monitor,
        printer,
        scanner,
        networkCard
        
    }
    public class Device
    {
        public string name { get; private set; }
        public EnumDeviceType typeDevice { get; private set; }
        public Driver driver { get; private set; }
        public bool ready { get; private set; }

        public Device(string name, EnumDeviceType typeDevice)
        {
            this.name = name;
            this.typeDevice = typeDevice;
            ready = false;
            this.driver = new Driver(name, typeDevice, 0);
        }

        public Device (Device device)
        {
            name = device.name;
            this.typeDevice = device.typeDevice;
            this.driver = device.driver;
            this.driver = new Driver(name, typeDevice, 0);
        }

        public Device(string name, EnumDeviceType typeDevice,Driver driver):this(name, typeDevice)
        {
            if (isCompatible(driver))
            {
                this.driver = driver;
            }
            ready = isReady();
            this.driver = new Driver(name, typeDevice, 0);
        }

        public void changeDriver(Driver driver)
        {
            this.driver = driver;
            ready = isReady();
        }
        public bool isReady()
        {
            try
            {
                return (int)typeDevice == (int)driver.deviceType;
            }
            catch (NullReferenceException) { }
            {
                return false;
            }
        }

        public bool isCompatible(Driver driver)
        {
            return (int)typeDevice == (int)driver.deviceType;
        }
        public override string ToString()
        {
            return (name + "  " + ((EnumDeviceType)typeDevice+"  готово к использованию: "+isReady().ToString()).ToString());
        }
    }
}
