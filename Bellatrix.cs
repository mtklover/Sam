using System.IO.Ports;
using System.Reflection;

namespace bellatrix
{
    public partial class Bellatrix : Form
    {
        public Bellatrix()
        {
            InitializeComponent();
        }

        // test
        List<Device> fakedevices = new();

        private void Bellatrix_Load(object sender, EventArgs e)
        {
            // get version info for label
            BellatrixLabel.Text = $"Bellatrix (v{Assembly.GetEntryAssembly()?.GetName().Version})";
            
            // test
            Device device1 = new("COM01");
            fakedevices.Add(device1);
            Device device2 = new("COM02");
            fakedevices.Add(device2);
            Device device3 = new("COM03");
            fakedevices.Add(device3);
            Device device4 = new("COM04");
            fakedevices.Add(device4);
            Device device5 = new("COM05");
            fakedevices.Add(device5);

        }

        private void RefreshDevicesButton_Click(object sender, EventArgs e)
        {
            // test
            DevicesDataGrid.DataSource = fakedevices;
        }
    }
}