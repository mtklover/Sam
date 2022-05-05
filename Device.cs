using System.IO.Ports;

namespace bellatrix
{
    internal class Device
    {
        public string? PortName { get; set; }
        public SerialPort? PortConnection { get; set; }

        public string? IMEI { get; set; }
        public string? SerialNo { get; set; }
        public string? ModelNo { get; set; }
        public string? Carrier { get; set; }
        public string? ActivationLock { get; set; }
        public string? StorageSize { get; set; }
        public string? NetworkLock { get; set; }
        public string? AndroidVersion { get; set; }

        internal Device()
        {
        }

        internal Device(Bellatrix bellatrix, string portname)
        {
            PortName = portname;
            PortConnection = new(portname);
            PortConnection.DataReceived += bellatrix.HandleResponse;
        }
    }
}