using System.IO.Ports;
using System.Reflection;

namespace bellatrix
{
    public partial class Bellatrix : Form
    {
        DataManager dataManager = new();
        List<Command> LoadedCommands = new();
        List<Script> LoadedScripts = new();
        List<Command> LoadedScriptCommands = new();

        public Bellatrix()
        {
            InitializeComponent();
        }

        // test devices
        List<Device> fakedevices = new();

        private void Bellatrix_Load(object sender, EventArgs e)
        {
            // get version info for label
            BellatrixLabel.Text = $"Bellatrix (v{Assembly.GetEntryAssembly()?.GetName().Version})";

            // check to see if files exist, and create default files if they dont
            dataManager.FileCheck();

            // load files
            LoadedCommands = dataManager.LoadCommands();
            RefreshCommandsButton.PerformClick();
            LoadedScripts = dataManager.LoadScripts();
            RefreshScriptsButton.PerformClick();

            // test devices
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
            DevicesDataGrid.DataSource = fakedevices;
            DevicesDataGrid.Columns["PortName"].HeaderText = "Port";
            DevicesDataGrid.Columns["PortConnection"].Visible = false;
            DevicesDataGrid.Columns["VID"].Visible = false;
            DevicesDataGrid.Columns["PID"].Visible = false;
        }

        private void RefreshCommandsButton_Click(object sender, EventArgs e)
        {
            CommandsDataGrid.DataSource = LoadedCommands;
            CommandsDataGrid.Columns["Instruction"].HeaderText = "Command";
            CommandsDataGrid.Columns["Delay"].Visible = false;
        }

        private void RefreshScriptsButton_Click(object sender, EventArgs e)
        {
            ScriptsDataGrid.DataSource = LoadedScripts;
            ScriptsDataGrid.Columns["Name"].HeaderText = "Script";
        }

        private void CommandsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = CommandsDataGrid.CurrentCell.RowIndex;
            foreach (var item in LoadedCommands)
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
            foreach (var item in LoadedScripts)
            {
                if (item.Name == ScriptsDataGrid["Name", rowindex].Value.ToString())
                {
                    ScriptTextBox.Text = item.Name;
                    ScriptDescTextBox.Text = item.Description;
                    ScriptCommandsDataGrid.DataSource = item.Commands;
                }
            }
        }

        private void SaveCommandButton_Click(object sender, EventArgs e)
        {
            //Command command = new(CommandTextBox.Text, CommandDescTextBox.Text);
            //dataManager.AddCommand(command);
        }

        private void SaveScriptButton_Click(object sender, EventArgs e)
        {
            //Script script = new(ScriptTextBox.Text, ScriptDescTextBox.Text);
            //dataManager.AddScript(script);
        }
    }
}