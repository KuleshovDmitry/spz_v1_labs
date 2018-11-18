using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Driver
    {
        public string name { get; private set; }
        public EnumDeviceType deviceType { get; private set; }
        public int version { get; private set; }
        public HashSet<string> supportingOS { get; private set; }


        public Driver(string name, EnumDeviceType deviceType,int version)
        {
            this.name = name;
            this.version = version;
            this.deviceType = deviceType;
            supportingOS = new HashSet<string>();
            supportingOS.Add("os1");
            supportingOS.Add("os2");
        }
        public Driver (string name, EnumDeviceType deviceType, int version, HashSet<string> supportingOS) 
            : this(name, deviceType,version)
        {
            this.supportingOS.Concat(supportingOS);
        }
        public bool isCompatible(string deviceType, string supportingOS)
        {
            if (deviceType.Equals(this.deviceType) && 
                this.supportingOS.Contains(supportingOS))
                return true;
            else return false;
        }
        public void update(int version)
        {
            if (this.version<version)
            {
                this.version = version;
            }
        }
        public void addSupportingOS(string osName) {
            supportingOS.Add(osName);
        }
        public static bool operator != (Driver driverFirst, Driver driverSecond)
        {
            return !(driverFirst==driverSecond);
        }
        public static bool operator == (Driver driverFirst, Driver driverSecond)
        {
            if (driverFirst == null) return false;
            else if (driverFirst.name.Equals(driverSecond.name) &&
                driverFirst.version == driverSecond.version &&
                driverFirst.deviceType.Equals(driverSecond.deviceType) &&
                driverFirst.supportingOS.Equals(driverSecond.supportingOS))
                return true;
            return false;
        }
        public override string ToString()
        {
            return (name + " " + deviceType.ToString() + " " + version.ToString());
        }
        
    }
}
