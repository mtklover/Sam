using System.Reflection;

namespace bellatrix
{
    public partial class Bellatrix : Form
    {
        private DataManager dataManager = new();
        private ConnectionManager connectionManager = new();

        private List<Command> LoadedCommands = new();
        private List<Script> LoadedScripts = new();
        private List<Command> LoadedScriptCommands = new();

        private List<Device> ConnectedDevices = new();

        public Bellatrix()
        {
            InitializeComponent();
        }

        // test devices
        private List<Device> fakedevices = new();

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
            foreach (var item in ConnectedDevices)
            {
                if (item.PortConnection.IsOpen)
                {
                    item.PortConnection.Close();
                }
            }
            ConnectedDevices = connectionManager.CollectDevices();
            DevicesDataGrid.DataSource = ConnectedDevices;
            //DevicesDataGrid.DataSource = fakedevices;
            DevicesDataGrid.Columns["PortName"].HeaderText = "Port";
            DevicesDataGrid.Columns["PortConnection"].Visible = false;
            DevicesDataGrid.ClearSelection();
        }

        private void RefreshCommandsButton_Click(object sender, EventArgs e)
        {
            LoadedCommands = dataManager.LoadCommands();
            CommandsDataGrid.DataSource = LoadedCommands;
            CommandsDataGrid.Columns["Instruction"].HeaderText = "Command";
            CommandsDataGrid.Columns["Delay"].Visible = false;
            CommandsDataGrid.ClearSelection();
            CommandTextBox.Text = "";
            CommandDescTextBox.Text = "";
        }

        private void RefreshScriptsButton_Click(object sender, EventArgs e)
        {
            LoadedScripts = dataManager.LoadScripts();
            ScriptsDataGrid.DataSource = LoadedScripts;
            ScriptsDataGrid.Columns["Name"].HeaderText = "Script";
            ScriptsDataGrid.ClearSelection();
            LoadedScriptCommands.Clear();
            ScriptCommandsDataGrid.DataSource = LoadedScriptCommands;
            ScriptTextBox.Text = "";
            ScriptDescTextBox.Text = "";
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
                    ScriptCommandsDataGrid.Columns["Description"].Visible = false;
                }
            }
        }

        private void SaveCommandButton_Click(object sender, EventArgs e)
        {
            Command command = new(CommandTextBox.Text, CommandDescTextBox.Text);
            dataManager.AddCommand(command);
            RefreshCommandsButton.PerformClick();
        }

        private void SaveScriptButton_Click(object sender, EventArgs e)
        {
            Script script = new(ScriptTextBox.Text, ScriptDescTextBox.Text, LoadedScriptCommands);
            dataManager.AddScript(script);
            RefreshScriptsButton.PerformClick();
        }

        private void NewCommandButton_Click(object sender, EventArgs e)
        {
            CommandsDataGrid.ClearSelection();
            CommandTextBox.Text = "";
            CommandDescTextBox.Text = "";
        }

        private void NewScriptButton_Click(object sender, EventArgs e)
        {
            ScriptsDataGrid.ClearSelection();
            LoadedScriptCommands.Clear();
            ScriptCommandsDataGrid.DataSource = LoadedScriptCommands;
            ScriptTextBox.Text = "";
            ScriptDescTextBox.Text = "";
        }

        private void DeleteCommandButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this command?", "Delete Command", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataManager.RemoveCommand(CommandTextBox.Text);
                RefreshCommandsButton.PerformClick();
            }
        }

        private void DeleteScriptButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this script?", "Delete Script", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataManager.RemoveScript(ScriptTextBox.Text);
                RefreshScriptsButton.PerformClick();
            }
        }
    }
}