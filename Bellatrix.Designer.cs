namespace bellatrix
{
    partial class Bellatrix
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BellatrixLabel = new System.Windows.Forms.Label();
            this.DevicesDataGrid = new System.Windows.Forms.DataGridView();
            this.DevicesLabel = new System.Windows.Forms.Label();
            this.RefreshDevicesButton = new System.Windows.Forms.Button();
            this.CommandsLabel = new System.Windows.Forms.Label();
            this.CommandsDataGrid = new System.Windows.Forms.DataGridView();
            this.NewCommandButton = new System.Windows.Forms.Button();
            this.DeleteCommandButton = new System.Windows.Forms.Button();
            this.SaveCommandButton = new System.Windows.Forms.Button();
            this.RunCommandButton = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandDescTextBox = new System.Windows.Forms.TextBox();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.CommandDescLabel = new System.Windows.Forms.Label();
            this.ScriptCommandsDataGrid = new System.Windows.Forms.DataGridView();
            this.ScriptCommandsLabel = new System.Windows.Forms.Label();
            this.ScriptLabel = new System.Windows.Forms.Label();
            this.ScriptDescLabel = new System.Windows.Forms.Label();
            this.ScriptsLabel = new System.Windows.Forms.Label();
            this.ScriptDescTextBox = new System.Windows.Forms.TextBox();
            this.NewScriptButton = new System.Windows.Forms.Button();
            this.DeleteScriptButton = new System.Windows.Forms.Button();
            this.SaveScriptButton = new System.Windows.Forms.Button();
            this.RunScriptButton = new System.Windows.Forms.Button();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.ScriptsDataGrid = new System.Windows.Forms.DataGridView();
            this.ConsoleTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.CommandLineTextBox = new System.Windows.Forms.TextBox();
            this.SendCommandButton = new System.Windows.Forms.Button();
            this.RefreshCommandsButton = new System.Windows.Forms.Button();
            this.RefreshScriptsButton = new System.Windows.Forms.Button();
            this.ClearConsoleButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DeleteScriptCommandButton = new System.Windows.Forms.Button();
            this.AddScriptCommandButton = new System.Windows.Forms.Button();
            this.ScriptsLoadedLabel = new System.Windows.Forms.Label();
            this.CommandsLoadedLabel = new System.Windows.Forms.Label();
            this.AddCommandToScriptButton = new System.Windows.Forms.Button();
            this.SRTLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommandsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptCommandsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BellatrixLabel
            // 
            this.BellatrixLabel.AutoSize = true;
            this.BellatrixLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BellatrixLabel.Location = new System.Drawing.Point(12, 9);
            this.BellatrixLabel.Name = "BellatrixLabel";
            this.BellatrixLabel.Size = new System.Drawing.Size(125, 37);
            this.BellatrixLabel.TabIndex = 0;
            this.BellatrixLabel.Text = "Bellatrix";
            // 
            // DevicesDataGrid
            // 
            this.DevicesDataGrid.AllowUserToAddRows = false;
            this.DevicesDataGrid.AllowUserToDeleteRows = false;
            this.DevicesDataGrid.AllowUserToResizeColumns = false;
            this.DevicesDataGrid.AllowUserToResizeRows = false;
            this.DevicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DevicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevicesDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DevicesDataGrid.Location = new System.Drawing.Point(12, 79);
            this.DevicesDataGrid.Name = "DevicesDataGrid";
            this.DevicesDataGrid.ReadOnly = true;
            this.DevicesDataGrid.RowHeadersVisible = false;
            this.DevicesDataGrid.RowTemplate.Height = 25;
            this.DevicesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DevicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DevicesDataGrid.ShowCellToolTips = false;
            this.DevicesDataGrid.ShowEditingIcon = false;
            this.DevicesDataGrid.Size = new System.Drawing.Size(1240, 160);
            this.DevicesDataGrid.TabIndex = 1;
            // 
            // DevicesLabel
            // 
            this.DevicesLabel.AutoSize = true;
            this.DevicesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DevicesLabel.Location = new System.Drawing.Point(12, 46);
            this.DevicesLabel.Name = "DevicesLabel";
            this.DevicesLabel.Size = new System.Drawing.Size(84, 30);
            this.DevicesLabel.TabIndex = 0;
            this.DevicesLabel.Text = "Devices";
            // 
            // RefreshDevicesButton
            // 
            this.RefreshDevicesButton.Location = new System.Drawing.Point(1177, 50);
            this.RefreshDevicesButton.Name = "RefreshDevicesButton";
            this.RefreshDevicesButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshDevicesButton.TabIndex = 2;
            this.RefreshDevicesButton.Text = "Refresh";
            this.RefreshDevicesButton.UseVisualStyleBackColor = true;
            this.RefreshDevicesButton.Click += new System.EventHandler(this.RefreshDevicesButton_Click);
            // 
            // CommandsLabel
            // 
            this.CommandsLabel.AutoSize = true;
            this.CommandsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandsLabel.Location = new System.Drawing.Point(12, 242);
            this.CommandsLabel.Name = "CommandsLabel";
            this.CommandsLabel.Size = new System.Drawing.Size(118, 30);
            this.CommandsLabel.TabIndex = 0;
            this.CommandsLabel.Text = "Commands";
            // 
            // CommandsDataGrid
            // 
            this.CommandsDataGrid.AllowUserToAddRows = false;
            this.CommandsDataGrid.AllowUserToDeleteRows = false;
            this.CommandsDataGrid.AllowUserToResizeColumns = false;
            this.CommandsDataGrid.AllowUserToResizeRows = false;
            this.CommandsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CommandsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommandsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CommandsDataGrid.Location = new System.Drawing.Point(12, 275);
            this.CommandsDataGrid.MultiSelect = false;
            this.CommandsDataGrid.Name = "CommandsDataGrid";
            this.CommandsDataGrid.ReadOnly = true;
            this.CommandsDataGrid.RowHeadersVisible = false;
            this.CommandsDataGrid.RowTemplate.Height = 25;
            this.CommandsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommandsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CommandsDataGrid.ShowCellToolTips = false;
            this.CommandsDataGrid.ShowEditingIcon = false;
            this.CommandsDataGrid.Size = new System.Drawing.Size(342, 282);
            this.CommandsDataGrid.TabIndex = 1;
            this.CommandsDataGrid.SelectionChanged += new System.EventHandler(this.CommandsDataGrid_SelectionChanged);
            // 
            // NewCommandButton
            // 
            this.NewCommandButton.Location = new System.Drawing.Point(198, 563);
            this.NewCommandButton.Name = "NewCommandButton";
            this.NewCommandButton.Size = new System.Drawing.Size(75, 23);
            this.NewCommandButton.TabIndex = 3;
            this.NewCommandButton.Text = "New";
            this.NewCommandButton.UseVisualStyleBackColor = true;
            this.NewCommandButton.Click += new System.EventHandler(this.NewCommandButton_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(12, 563);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCommandButton.TabIndex = 3;
            this.DeleteCommandButton.Text = "Delete";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // SaveCommandButton
            // 
            this.SaveCommandButton.Location = new System.Drawing.Point(279, 563);
            this.SaveCommandButton.Name = "SaveCommandButton";
            this.SaveCommandButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCommandButton.TabIndex = 3;
            this.SaveCommandButton.Text = "Save";
            this.SaveCommandButton.UseVisualStyleBackColor = true;
            this.SaveCommandButton.Click += new System.EventHandler(this.SaveCommandButton_Click);
            // 
            // RunCommandButton
            // 
            this.RunCommandButton.Location = new System.Drawing.Point(279, 621);
            this.RunCommandButton.Name = "RunCommandButton";
            this.RunCommandButton.Size = new System.Drawing.Size(75, 23);
            this.RunCommandButton.TabIndex = 3;
            this.RunCommandButton.Text = "Run";
            this.RunCommandButton.UseVisualStyleBackColor = true;
            this.RunCommandButton.Click += new System.EventHandler(this.RunCommandButton_Click);
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(12, 650);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(342, 23);
            this.CommandTextBox.TabIndex = 4;
            // 
            // CommandDescTextBox
            // 
            this.CommandDescTextBox.Location = new System.Drawing.Point(12, 696);
            this.CommandDescTextBox.Multiline = true;
            this.CommandDescTextBox.Name = "CommandDescTextBox";
            this.CommandDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommandDescTextBox.Size = new System.Drawing.Size(342, 124);
            this.CommandDescTextBox.TabIndex = 4;
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandLabel.Location = new System.Drawing.Point(12, 630);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(68, 17);
            this.CommandLabel.TabIndex = 0;
            this.CommandLabel.Text = "Command";
            // 
            // CommandDescLabel
            // 
            this.CommandDescLabel.AutoSize = true;
            this.CommandDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandDescLabel.Location = new System.Drawing.Point(12, 676);
            this.CommandDescLabel.Name = "CommandDescLabel";
            this.CommandDescLabel.Size = new System.Drawing.Size(74, 17);
            this.CommandDescLabel.TabIndex = 0;
            this.CommandDescLabel.Text = "Description";
            // 
            // ScriptCommandsDataGrid
            // 
            this.ScriptCommandsDataGrid.AllowUserToResizeColumns = false;
            this.ScriptCommandsDataGrid.AllowUserToResizeRows = false;
            this.ScriptCommandsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScriptCommandsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptCommandsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ScriptCommandsDataGrid.Location = new System.Drawing.Point(708, 275);
            this.ScriptCommandsDataGrid.MultiSelect = false;
            this.ScriptCommandsDataGrid.Name = "ScriptCommandsDataGrid";
            this.ScriptCommandsDataGrid.RowHeadersVisible = false;
            this.ScriptCommandsDataGrid.RowTemplate.Height = 25;
            this.ScriptCommandsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScriptCommandsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptCommandsDataGrid.Size = new System.Drawing.Size(544, 545);
            this.ScriptCommandsDataGrid.TabIndex = 1;
            // 
            // ScriptCommandsLabel
            // 
            this.ScriptCommandsLabel.AutoSize = true;
            this.ScriptCommandsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptCommandsLabel.Location = new System.Drawing.Point(708, 255);
            this.ScriptCommandsLabel.Name = "ScriptCommandsLabel";
            this.ScriptCommandsLabel.Size = new System.Drawing.Size(111, 17);
            this.ScriptCommandsLabel.TabIndex = 0;
            this.ScriptCommandsLabel.Text = "Script Commands";
            // 
            // ScriptLabel
            // 
            this.ScriptLabel.AutoSize = true;
            this.ScriptLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptLabel.Location = new System.Drawing.Point(360, 630);
            this.ScriptLabel.Name = "ScriptLabel";
            this.ScriptLabel.Size = new System.Drawing.Size(41, 17);
            this.ScriptLabel.TabIndex = 0;
            this.ScriptLabel.Text = "Script";
            // 
            // ScriptDescLabel
            // 
            this.ScriptDescLabel.AutoSize = true;
            this.ScriptDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptDescLabel.Location = new System.Drawing.Point(360, 676);
            this.ScriptDescLabel.Name = "ScriptDescLabel";
            this.ScriptDescLabel.Size = new System.Drawing.Size(74, 17);
            this.ScriptDescLabel.TabIndex = 0;
            this.ScriptDescLabel.Text = "Description";
            // 
            // ScriptsLabel
            // 
            this.ScriptsLabel.AutoSize = true;
            this.ScriptsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptsLabel.Location = new System.Drawing.Point(360, 242);
            this.ScriptsLabel.Name = "ScriptsLabel";
            this.ScriptsLabel.Size = new System.Drawing.Size(74, 30);
            this.ScriptsLabel.TabIndex = 0;
            this.ScriptsLabel.Text = "Scripts";
            // 
            // ScriptDescTextBox
            // 
            this.ScriptDescTextBox.Location = new System.Drawing.Point(360, 696);
            this.ScriptDescTextBox.Multiline = true;
            this.ScriptDescTextBox.Name = "ScriptDescTextBox";
            this.ScriptDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScriptDescTextBox.Size = new System.Drawing.Size(342, 124);
            this.ScriptDescTextBox.TabIndex = 4;
            // 
            // NewScriptButton
            // 
            this.NewScriptButton.Location = new System.Drawing.Point(546, 563);
            this.NewScriptButton.Name = "NewScriptButton";
            this.NewScriptButton.Size = new System.Drawing.Size(75, 23);
            this.NewScriptButton.TabIndex = 3;
            this.NewScriptButton.Text = "New";
            this.NewScriptButton.UseVisualStyleBackColor = true;
            this.NewScriptButton.Click += new System.EventHandler(this.NewScriptButton_Click);
            // 
            // DeleteScriptButton
            // 
            this.DeleteScriptButton.Location = new System.Drawing.Point(360, 563);
            this.DeleteScriptButton.Name = "DeleteScriptButton";
            this.DeleteScriptButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteScriptButton.TabIndex = 3;
            this.DeleteScriptButton.Text = "Delete";
            this.DeleteScriptButton.UseVisualStyleBackColor = true;
            this.DeleteScriptButton.Click += new System.EventHandler(this.DeleteScriptButton_Click);
            // 
            // SaveScriptButton
            // 
            this.SaveScriptButton.Location = new System.Drawing.Point(627, 563);
            this.SaveScriptButton.Name = "SaveScriptButton";
            this.SaveScriptButton.Size = new System.Drawing.Size(75, 23);
            this.SaveScriptButton.TabIndex = 3;
            this.SaveScriptButton.Text = "Save";
            this.SaveScriptButton.UseVisualStyleBackColor = true;
            this.SaveScriptButton.Click += new System.EventHandler(this.SaveScriptButton_Click);
            // 
            // RunScriptButton
            // 
            this.RunScriptButton.Location = new System.Drawing.Point(627, 621);
            this.RunScriptButton.Name = "RunScriptButton";
            this.RunScriptButton.Size = new System.Drawing.Size(75, 23);
            this.RunScriptButton.TabIndex = 3;
            this.RunScriptButton.Text = "Run";
            this.RunScriptButton.UseVisualStyleBackColor = true;
            this.RunScriptButton.Click += new System.EventHandler(this.RunScriptButton_Click);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(360, 650);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(342, 23);
            this.ScriptTextBox.TabIndex = 4;
            // 
            // ScriptsDataGrid
            // 
            this.ScriptsDataGrid.AllowUserToAddRows = false;
            this.ScriptsDataGrid.AllowUserToDeleteRows = false;
            this.ScriptsDataGrid.AllowUserToResizeColumns = false;
            this.ScriptsDataGrid.AllowUserToResizeRows = false;
            this.ScriptsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScriptsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ScriptsDataGrid.Location = new System.Drawing.Point(360, 275);
            this.ScriptsDataGrid.MultiSelect = false;
            this.ScriptsDataGrid.Name = "ScriptsDataGrid";
            this.ScriptsDataGrid.ReadOnly = true;
            this.ScriptsDataGrid.RowHeadersVisible = false;
            this.ScriptsDataGrid.RowTemplate.Height = 25;
            this.ScriptsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScriptsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptsDataGrid.ShowCellToolTips = false;
            this.ScriptsDataGrid.ShowEditingIcon = false;
            this.ScriptsDataGrid.Size = new System.Drawing.Size(342, 282);
            this.ScriptsDataGrid.TabIndex = 1;
            this.ScriptsDataGrid.SelectionChanged += new System.EventHandler(this.ScriptsDataGrid_SelectionChanged);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(1258, 79);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleTextBox.Size = new System.Drawing.Size(314, 712);
            this.ConsoleTextBox.TabIndex = 4;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleLabel.Location = new System.Drawing.Point(1258, 46);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(87, 30);
            this.ConsoleLabel.TabIndex = 0;
            this.ConsoleLabel.Text = "Console";
            // 
            // CommandLineTextBox
            // 
            this.CommandLineTextBox.Location = new System.Drawing.Point(1258, 797);
            this.CommandLineTextBox.Name = "CommandLineTextBox";
            this.CommandLineTextBox.Size = new System.Drawing.Size(233, 23);
            this.CommandLineTextBox.TabIndex = 4;
            this.CommandLineTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandLineTextBox_KeyDown);
            // 
            // SendCommandButton
            // 
            this.SendCommandButton.Location = new System.Drawing.Point(1497, 796);
            this.SendCommandButton.Name = "SendCommandButton";
            this.SendCommandButton.Size = new System.Drawing.Size(75, 23);
            this.SendCommandButton.TabIndex = 3;
            this.SendCommandButton.Text = "Send";
            this.SendCommandButton.UseVisualStyleBackColor = true;
            this.SendCommandButton.Click += new System.EventHandler(this.SendCommandButton_Click);
            // 
            // RefreshCommandsButton
            // 
            this.RefreshCommandsButton.Location = new System.Drawing.Point(279, 246);
            this.RefreshCommandsButton.Name = "RefreshCommandsButton";
            this.RefreshCommandsButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshCommandsButton.TabIndex = 3;
            this.RefreshCommandsButton.Text = "Refresh";
            this.RefreshCommandsButton.UseVisualStyleBackColor = true;
            this.RefreshCommandsButton.Click += new System.EventHandler(this.RefreshCommandsButton_Click);
            // 
            // RefreshScriptsButton
            // 
            this.RefreshScriptsButton.Location = new System.Drawing.Point(627, 246);
            this.RefreshScriptsButton.Name = "RefreshScriptsButton";
            this.RefreshScriptsButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshScriptsButton.TabIndex = 3;
            this.RefreshScriptsButton.Text = "Refresh";
            this.RefreshScriptsButton.UseVisualStyleBackColor = true;
            this.RefreshScriptsButton.Click += new System.EventHandler(this.RefreshScriptsButton_Click);
            // 
            // ClearConsoleButton
            // 
            this.ClearConsoleButton.Location = new System.Drawing.Point(1497, 50);
            this.ClearConsoleButton.Name = "ClearConsoleButton";
            this.ClearConsoleButton.Size = new System.Drawing.Size(75, 23);
            this.ClearConsoleButton.TabIndex = 2;
            this.ClearConsoleButton.Text = "Clear";
            this.ClearConsoleButton.UseVisualStyleBackColor = true;
            this.ClearConsoleButton.Click += new System.EventHandler(this.ClearConsoleButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 826);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1560, 23);
            this.ProgressBar.TabIndex = 5;
            // 
            // DeleteScriptCommandButton
            // 
            this.DeleteScriptCommandButton.Location = new System.Drawing.Point(1177, 246);
            this.DeleteScriptCommandButton.Name = "DeleteScriptCommandButton";
            this.DeleteScriptCommandButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteScriptCommandButton.TabIndex = 3;
            this.DeleteScriptCommandButton.Text = "Delete";
            this.DeleteScriptCommandButton.UseVisualStyleBackColor = true;
            this.DeleteScriptCommandButton.Click += new System.EventHandler(this.DeleteScriptCommandButton_Click);
            // 
            // AddScriptCommandButton
            // 
            this.AddScriptCommandButton.Location = new System.Drawing.Point(1096, 245);
            this.AddScriptCommandButton.Name = "AddScriptCommandButton";
            this.AddScriptCommandButton.Size = new System.Drawing.Size(75, 23);
            this.AddScriptCommandButton.TabIndex = 3;
            this.AddScriptCommandButton.Text = "Add";
            this.AddScriptCommandButton.UseVisualStyleBackColor = true;
            this.AddScriptCommandButton.Click += new System.EventHandler(this.AddScriptCommandButton_Click);
            // 
            // ScriptsLoadedLabel
            // 
            this.ScriptsLoadedLabel.AutoSize = true;
            this.ScriptsLoadedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptsLoadedLabel.Location = new System.Drawing.Point(440, 248);
            this.ScriptsLoadedLabel.Name = "ScriptsLoadedLabel";
            this.ScriptsLoadedLabel.Size = new System.Drawing.Size(38, 17);
            this.ScriptsLoadedLabel.TabIndex = 0;
            this.ScriptsLoadedLabel.Text = "------";
            // 
            // CommandsLoadedLabel
            // 
            this.CommandsLoadedLabel.AutoSize = true;
            this.CommandsLoadedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandsLoadedLabel.Location = new System.Drawing.Point(136, 248);
            this.CommandsLoadedLabel.Name = "CommandsLoadedLabel";
            this.CommandsLoadedLabel.Size = new System.Drawing.Size(38, 17);
            this.CommandsLoadedLabel.TabIndex = 0;
            this.CommandsLoadedLabel.Text = "------";
            // 
            // AddCommandToScriptButton
            // 
            this.AddCommandToScriptButton.Location = new System.Drawing.Point(198, 592);
            this.AddCommandToScriptButton.Name = "AddCommandToScriptButton";
            this.AddCommandToScriptButton.Size = new System.Drawing.Size(156, 23);
            this.AddCommandToScriptButton.TabIndex = 3;
            this.AddCommandToScriptButton.Text = "Add Command To Script";
            this.AddCommandToScriptButton.UseVisualStyleBackColor = true;
            this.AddCommandToScriptButton.Click += new System.EventHandler(this.AddCommandToScriptButton_Click);
            // 
            // SRTLabel
            // 
            this.SRTLabel.AutoSize = true;
            this.SRTLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SRTLabel.Location = new System.Drawing.Point(136, 15);
            this.SRTLabel.Name = "SRTLabel";
            this.SRTLabel.Size = new System.Drawing.Size(231, 30);
            this.SRTLabel.TabIndex = 0;
            this.SRTLabel.Text = "Samsung Research Tool";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(1485, 9);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(0, 30);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bellatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ScriptDescTextBox);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.CommandDescTextBox);
            this.Controls.Add(this.CommandLineTextBox);
            this.Controls.Add(this.CommandTextBox);
            this.Controls.Add(this.RunScriptButton);
            this.Controls.Add(this.RunCommandButton);
            this.Controls.Add(this.SaveScriptButton);
            this.Controls.Add(this.SaveCommandButton);
            this.Controls.Add(this.DeleteScriptButton);
            this.Controls.Add(this.AddCommandToScriptButton);
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.NewScriptButton);
            this.Controls.Add(this.SendCommandButton);
            this.Controls.Add(this.AddScriptCommandButton);
            this.Controls.Add(this.DeleteScriptCommandButton);
            this.Controls.Add(this.RefreshScriptsButton);
            this.Controls.Add(this.RefreshCommandsButton);
            this.Controls.Add(this.NewCommandButton);
            this.Controls.Add(this.ClearConsoleButton);
            this.Controls.Add(this.RefreshDevicesButton);
            this.Controls.Add(this.ScriptCommandsDataGrid);
            this.Controls.Add(this.ScriptsDataGrid);
            this.Controls.Add(this.CommandsDataGrid);
            this.Controls.Add(this.DevicesDataGrid);
            this.Controls.Add(this.CommandsLoadedLabel);
            this.Controls.Add(this.ScriptsLoadedLabel);
            this.Controls.Add(this.ScriptCommandsLabel);
            this.Controls.Add(this.ScriptsLabel);
            this.Controls.Add(this.ScriptDescLabel);
            this.Controls.Add(this.CommandDescLabel);
            this.Controls.Add(this.ScriptLabel);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.CommandsLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SRTLabel);
            this.Controls.Add(this.DevicesLabel);
            this.Controls.Add(this.BellatrixLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bellatrix";
            this.Text = "Bellatrix";
            this.Load += new System.EventHandler(this.Bellatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DevicesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommandsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptCommandsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BellatrixLabel;
        private DataGridView DevicesDataGrid;
        private Label DevicesLabel;
        private Button RefreshDevicesButton;
        private Label CommandsLabel;
        private DataGridView CommandsDataGrid;
        private Button NewCommandButton;
        private Button DeleteCommandButton;
        private Button SaveCommandButton;
        private Button RunCommandButton;
        private TextBox CommandTextBox;
        private TextBox CommandDescTextBox;
        private Label CommandLabel;
        private Label CommandDescLabel;
        private DataGridView ScriptCommandsDataGrid;
        private Label ScriptCommandsLabel;
        private Label ScriptLabel;
        private Label ScriptDescLabel;
        private Label ScriptsLabel;
        private TextBox ScriptDescTextBox;
        private Button NewScriptButton;
        private Button DeleteScriptButton;
        private Button SaveScriptButton;
        private Button RunScriptButton;
        private TextBox ScriptTextBox;
        private DataGridView ScriptsDataGrid;
        private Label ConsoleLabel;
        private TextBox CommandLineTextBox;
        private Button SendCommandButton;
        private Button RefreshCommandsButton;
        private Button RefreshScriptsButton;
        private Button ClearConsoleButton;
        internal TextBox ConsoleTextBox;
        private ProgressBar ProgressBar;
        private Button DeleteScriptCommandButton;
        private Button AddScriptCommandButton;
        private Label ScriptsLoadedLabel;
        private Label CommandsLoadedLabel;
        private Button AddCommandToScriptButton;
        private Label SRTLabel;
        private Label VersionLabel;
    }
}