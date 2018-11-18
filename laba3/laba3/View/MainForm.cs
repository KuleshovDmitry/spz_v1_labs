using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            isReadyTextBox.Text = Controller.driverManager.isReady().ToString();
        }
        private void generation_Click(object sender, EventArgs e)
        {
            Controller.genrateRandomDrivers();
            rewriteDriverList();
        }
        private void rewriteDriverList()
        {
            driverListBox.Items.Clear();
            foreach (Driver driverIt in Controller.driverManager.driverMap.Values)
            {
                driverListBox.Items.Add(driverIt);
            }
        }
        private void deleteDriver_Click(object sender, EventArgs e)
        {
            if ((Object)driverListBox.SelectedItem != null)
            {
                Controller.driverManager.deleteDriver((Driver)driverListBox.SelectedItem);
                driverListBox.Items.Remove(driverListBox.SelectedItem);
            }
        }
        private void addDevice_Click(object sender, EventArgs e)
        {
            AddDevice addDeviceForm = new AddDevice();
            if (addDeviceForm.ShowDialog() == DialogResult.OK)
            {
                Device device = addDeviceForm.device;
                Controller.driverManager.addDevice(device);
                deviceListBox.Items.Add(device);
                stateChangeResponse();
            }
        }
        private void equals_Click(object sender, EventArgs e)
        {
            DriversCompare driversCompare = new DriversCompare(Controller.driverManager.driverMap);
            driversCompare.Show();
        }
        private void deleteDevice_Click(object sender, EventArgs e)
        {
            deviceListBox.Items.Remove(deviceListBox.SelectedItem);
            Controller.driverManager.deleteDevice((Device)deviceListBox.SelectedItem);
            isReadyTextBox.Text = Controller.driverManager.isReady().ToString();
        }

        private void deviceListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Device device = (Device)listBox.SelectedItem;
            AddDevice addDeviceForm = new AddDevice();

            if (addDeviceForm.ShowDialog() == DialogResult.OK)
            {
                deviceListBox.Items.Remove(deviceListBox.SelectedItem);
                Controller.driverManager.deleteDevice((Device)listBox.SelectedItem);

                device = addDeviceForm.device;

                Controller.driverManager.addDevice(device);
                deviceListBox.Items.Add(addDeviceForm.device);

                stateChangeResponse();
            }
        }
        private void driverListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           ListBox listBox = sender as ListBox;
           changeDriver((Driver)listBox.SelectedItem);
        }
        private void addDriverButton_Click(object sender, EventArgs e)
        {
            changeDriver(null);
        }
        public void changeDriver(Driver driver)
        {
            
            ChangeDriver changeDriver = new ChangeDriver();
            if (changeDriver.ShowDialog() == DialogResult.OK)
            {
                Controller.changeDriver(driver, changeDriver.driver);
            }
            rewriteDriverList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((Object)deviceListBox.SelectedItem !=null &&
                (Object)driverListBox.SelectedItem !=null)
                {
                Device device = (Device)deviceListBox.SelectedItem;
                device.changeDriver((Driver)driverListBox.SelectedItem);
                stateChangeResponse();
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((Object)deviceListBox.SelectedItem != null &&
                (Object)driverListBox.SelectedItem != null)
            {
                Device device = (Device)deviceListBox.SelectedItem;
                device.changeDriver(null);
                stateChangeResponse();
            }
        }
        private void stateChangeResponse()
        {
            isReadyTextBox.Text = Controller.driverManager.isReady().ToString();
            deviceListBox.Items.Clear();
            foreach (Device deviceIt in Controller.driverManager.deviceList)
            {
                deviceListBox.Items.Add(deviceIt);
            }
        }
    }
}
