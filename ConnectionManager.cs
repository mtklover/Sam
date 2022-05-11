using System.IO.Ports;

namespace bellatrix
{
    internal class ConnectionManager
    {
        internal List<Device> CollectDevices(Bellatrix bellatrix)
        {
            List<Device> devices = new();

            string[] ports = SerialPort.GetPortNames();

            if (ports.Count() > 0)
            {
                foreach (string port in ports)
                {
                    Device device = new(bellatrix, port);

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
                        bellatrix.ConsoleTextBox.AppendText($"Bellatrix: Connected to {device.PortName}" + Environment.NewLine);
                    }
                }
            }
            else
            {
                bellatrix.ConsoleTextBox.AppendText("Bellatrix: No devices found" + Environment.NewLine);
            }
            

            return devices;
        }

        internal void RunCommand(Device device, Command command)
        {
            device.PortConnection.Write($"{command.Instruction}\r\n");
        }

        internal void RunScript(Bellatrix bellatrix, Device device, Script script, ProgressBar progressbar, bool one, bool two)
        {
            int count = 0;
            int progressnum = 1;

            IProgress<int> progress = new Progress<int>(value =>
            {
                bellatrix.BeginInvoke(new Action(() => { progressbar.Value = value; }));
            });

            foreach (Command command in script.Commands)
            {
                count++;
                var percentComplete = (progressnum * 100) / script.Commands.Count;
                progressnum++;
                progress.Report(percentComplete);

                device.PortConnection.Write($"{command.Instruction}\r\n");
                Thread.Sleep(Convert.ToInt32(command.Delay));

               
            }
            bellatrix.BeginInvoke(new Action(() => { progressbar.Value = 0; }));
        }
    }
}