using System.IO.Ports;
using System.Reflection;

namespace bellatrix
{
    public partial class Bellatrix : Form
    {
        DataManager dataManager = new();
        public Bellatrix()
        {
            InitializeComponent();
        }

        // test data
        List<Device> fakedevices = new();
        List<Command> fakecommands = new();
        List<Script> fakescripts = new();

        private void Bellatrix_Load(object sender, EventArgs e)
        {
            // get version info for label
            BellatrixLabel.Text = $"Bellatrix (v{Assembly.GetEntryAssembly()?.GetName().Version})";
            
            // test data
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
            Command command1 = new("test1", "gkdjfsgkjsdhflkgjhsdjfkgh");
            fakecommands.Add(command1);
            Command command2 = new("test2", "84u8f934hfuhersuhfgsdhgfjk");
            fakecommands.Add(command2);
            Command command3 = new("test3", "kvmnvbmnjfghdefghriuewhgiuhweg");
            fakecommands.Add(command3);
            Script script1 = new("test1", "gkdjfsgkjsdhflkgjhsdjfkgh");
            fakescripts.Add(script1);
            Script script2 = new("test2", "84u8f934hfuhersuhfgsdhgfjk");
            fakescripts.Add(script2);
            Script script3 = new("test3", "kvmnvbmnjfghdefghriuewhgiuhweg");
            fakescripts.Add(script3);
        }

        private void RefreshDevicesButton_Click(object sender, EventArgs e)
        {
            DevicesDataGrid.DataSource = fakedevices;
            DevicesDataGrid.Columns["PortName"].HeaderText = "Port";
            DevicesDataGrid.Columns["PortConnection"].Visible = false;
            DevicesDataGrid.Columns["VID"].Visible = false;
            DevicesDataGrid.Columns["PID"].Visible = false;
        }

        private void RefreshCommandsButton_Click(object sender, EventArgs e)
        {
            CommandsDataGrid.DataSource = fakecommands;
            CommandsDataGrid.Columns["Instruction"].HeaderText = "Command";
            CommandsDataGrid.Columns["Delay"].Visible = false;
        }

        private void RefreshScriptsButton_Click(object sender, EventArgs e)
        {
            ScriptsDataGrid.DataSource = fakescripts;
            ScriptsDataGrid.Columns["Name"].HeaderText = "Script";
        }

        private void CommandsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = CommandsDataGrid.CurrentCell.RowIndex;
            foreach (var item in fakecommands)
            {
                if (item.Instruction == CommandsDataGrid["Instruction", rowindex].Value.ToString())
                {
                    CommandTextBox.Text = item.Instruction;
                    CommandDescTextBox.Text = item.Description;
                }
            }
        }

        private void ScriptsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = ScriptsDataGrid.CurrentCell.RowIndex;
            foreach (var item in fakescripts)
            {
                if (item.Name == ScriptsDataGrid["Name", rowindex].Value.ToString())
                {
                    ScriptTextBox.Text = item.Name;
                    ScriptDescTextBox.Text = item.Description;
                }
            }
        }

        private void SaveCommandButton_Click(object sender, EventArgs e)
        {
            Command command = new(CommandTextBox.Text, CommandDescTextBox.Text);
            dataManager.AddCommand(command);
        }

        private void SaveScriptButton_Click(object sender, EventArgs e)
        {
            Script script = new(ScriptTextBox.Text, ScriptDescTextBox.Text);
            dataManager.AddScript(script);
        }
    }
}