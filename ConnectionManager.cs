using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellatrix
{
    internal class ConnectionManager
    {
        internal List<Device> CollectDevices()
        {
            List<Device> devices = new();

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                Device device = new(port);

                try
                {
                    device.PortConnection.Open();
                }
                catch
                {
                    device.PortName = device.PortName + "ERROR";
                }

                if (device.PortConnection.IsOpen)
                {
                    devices.Add(device);
                }
            }

            return devices;
        }
    }
}
