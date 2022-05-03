using System.IO.Ports;

namespace bellatrix
{
    internal class Device
    {
        // connection information
        public string PortName { get; set; }

        public SerialPort PortConnection { get; set; }

        // extra information
        public CheckBox Selected { get; set; }

        internal Device(string portname)
        {
            PortName = portname;
            PortConnection = new(portname);
            Selected = new CheckBox();
        }
    }
}