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
            this.CommandsLabel.Location = new System.Drawing.Point(484, 242);
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
            this.CommandsDataGrid.Location = new System.Drawing.Point(484, 304);
            this.CommandsDataGrid.MultiSelect = false;
            this.CommandsDataGrid.Name = "CommandsDataGrid";
            this.CommandsDataGrid.ReadOnly = true;
            this.CommandsDataGrid.RowHeadersVisible = false;
            this.CommandsDataGrid.RowTemplate.Height = 25;
            this.CommandsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CommandsDataGrid.ShowCellToolTips = false;
            this.CommandsDataGrid.ShowEditingIcon = false;
            this.CommandsDataGrid.Size = new System.Drawing.Size(252, 165);
            this.CommandsDataGrid.TabIndex = 1;
            this.CommandsDataGrid.SelectionChanged += new System.EventHandler(this.CommandsDataGrid_SelectionChanged);
            // 
            // NewCommandButton
            // 
            this.NewCommandButton.Location = new System.Drawing.Point(484, 275);
            this.NewCommandButton.Name = "NewCommandButton";
            this.NewCommandButton.Size = new System.Drawing.Size(75, 23);
            this.NewCommandButton.TabIndex = 3;
            this.NewCommandButton.Text = "New";
            this.NewCommandButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(484, 475);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCommandButton.TabIndex = 3;
            this.DeleteCommandButton.Text = "Delete";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            // 
            // SaveCommandButton
            // 
            this.SaveCommandButton.Location = new System.Drawing.Point(580, 516);
            this.SaveCommandButton.Name = "SaveCommandButton";
            this.SaveCommandButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCommandButton.TabIndex = 3;
            this.SaveCommandButton.Text = "Save";
            this.SaveCommandButton.UseVisualStyleBackColor = true;
            this.SaveCommandButton.Click += new System.EventHandler(this.SaveCommandButton_Click);
            // 
            // RunCommandButton
            // 
            this.RunCommandButton.Location = new System.Drawing.Point(661, 516);
            this.RunCommandButton.Name = "RunCommandButton";
            this.RunCommandButton.Size = new System.Drawing.Size(75, 23);
            this.RunCommandButton.TabIndex = 3;
            this.RunCommandButton.Text = "Run";
            this.RunCommandButton.UseVisualStyleBackColor = true;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(484, 545);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(252, 23);
            this.CommandTextBox.TabIndex = 4;
            // 
            // CommandDescTextBox
            // 
            this.CommandDescTextBox.Location = new System.Drawing.Point(484, 591);
            this.CommandDescTextBox.Multiline = true;
            this.CommandDescTextBox.Name = "CommandDescTextBox";
            this.CommandDescTextBox.Size = new System.Drawing.Size(252, 78);
            this.CommandDescTextBox.TabIndex = 4;
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandLabel.Location = new System.Drawing.Point(484, 525);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(68, 17);
            this.CommandLabel.TabIndex = 0;
            this.CommandLabel.Text = "Command";
            // 
            // CommandDescLabel
            // 
            this.CommandDescLabel.AutoSize = true;
            this.CommandDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandDescLabel.Location = new System.Drawing.Point(484, 571);
            this.CommandDescLabel.Name = "CommandDescLabel";
            this.CommandDescLabel.Size = new System.Drawing.Size(74, 17);
            this.CommandDescLabel.TabIndex = 0;
            this.CommandDescLabel.Text = "Description";
            // 
            // ScriptCommandsDataGrid
            // 
            this.ScriptCommandsDataGrid.AllowUserToAddRows = false;
            this.ScriptCommandsDataGrid.AllowUserToDeleteRows = false;
            this.ScriptCommandsDataGrid.AllowUserToResizeColumns = false;
            this.ScriptCommandsDataGrid.AllowUserToResizeRows = false;
            this.ScriptCommandsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScriptCommandsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptCommandsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ScriptCommandsDataGrid.Location = new System.Drawing.Point(1000, 304);
            this.ScriptCommandsDataGrid.Name = "ScriptCommandsDataGrid";
            this.ScriptCommandsDataGrid.ReadOnly = true;
            this.ScriptCommandsDataGrid.RowHeadersVisible = false;
            this.ScriptCommandsDataGrid.RowTemplate.Height = 25;
            this.ScriptCommandsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptCommandsDataGrid.ShowCellToolTips = false;
            this.ScriptCommandsDataGrid.ShowEditingIcon = false;
            this.ScriptCommandsDataGrid.Size = new System.Drawing.Size(252, 365);
            this.ScriptCommandsDataGrid.TabIndex = 1;
            // 
            // ScriptCommandsLabel
            // 
            this.ScriptCommandsLabel.AutoSize = true;
            this.ScriptCommandsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptCommandsLabel.Location = new System.Drawing.Point(1000, 284);
            this.ScriptCommandsLabel.Name = "ScriptCommandsLabel";
            this.ScriptCommandsLabel.Size = new System.Drawing.Size(74, 17);
            this.ScriptCommandsLabel.TabIndex = 0;
            this.ScriptCommandsLabel.Text = "Commands";
            // 
            // ScriptLabel
            // 
            this.ScriptLabel.AutoSize = true;
            this.ScriptLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptLabel.Location = new System.Drawing.Point(742, 525);
            this.ScriptLabel.Name = "ScriptLabel";
            this.ScriptLabel.Size = new System.Drawing.Size(41, 17);
            this.ScriptLabel.TabIndex = 0;
            this.ScriptLabel.Text = "Script";
            // 
            // ScriptDescLabel
            // 
            this.ScriptDescLabel.AutoSize = true;
            this.ScriptDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptDescLabel.Location = new System.Drawing.Point(742, 571);
            this.ScriptDescLabel.Name = "ScriptDescLabel";
            this.ScriptDescLabel.Size = new System.Drawing.Size(74, 17);
            this.ScriptDescLabel.TabIndex = 0;
            this.ScriptDescLabel.Text = "Description";
            // 
            // ScriptsLabel
            // 
            this.ScriptsLabel.AutoSize = true;
            this.ScriptsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScriptsLabel.Location = new System.Drawing.Point(742, 242);
            this.ScriptsLabel.Name = "ScriptsLabel";
            this.ScriptsLabel.Size = new System.Drawing.Size(74, 30);
            this.ScriptsLabel.TabIndex = 0;
            this.ScriptsLabel.Text = "Scripts";
            // 
            // ScriptDescTextBox
            // 
            this.ScriptDescTextBox.Location = new System.Drawing.Point(742, 591);
            this.ScriptDescTextBox.Multiline = true;
            this.ScriptDescTextBox.Name = "ScriptDescTextBox";
            this.ScriptDescTextBox.Size = new System.Drawing.Size(252, 78);
            this.ScriptDescTextBox.TabIndex = 4;
            // 
            // NewScriptButton
            // 
            this.NewScriptButton.Location = new System.Drawing.Point(742, 275);
            this.NewScriptButton.Name = "NewScriptButton";
            this.NewScriptButton.Size = new System.Drawing.Size(75, 23);
            this.NewScriptButton.TabIndex = 3;
            this.NewScriptButton.Text = "New";
            this.NewScriptButton.UseVisualStyleBackColor = true;
            // 
            // DeleteScriptButton
            // 
            this.DeleteScriptButton.Location = new System.Drawing.Point(742, 475);
            this.DeleteScriptButton.Name = "DeleteScriptButton";
            this.DeleteScriptButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteScriptButton.TabIndex = 3;
            this.DeleteScriptButton.Text = "Delete";
            this.DeleteScriptButton.UseVisualStyleBackColor = true;
            // 
            // SaveScriptButton
            // 
            this.SaveScriptButton.Location = new System.Drawing.Point(838, 516);
            this.SaveScriptButton.Name = "SaveScriptButton";
            this.SaveScriptButton.Size = new System.Drawing.Size(75, 23);
            this.SaveScriptButton.TabIndex = 3;
            this.SaveScriptButton.Text = "Save";
            this.SaveScriptButton.UseVisualStyleBackColor = true;
            this.SaveScriptButton.Click += new System.EventHandler(this.SaveScriptButton_Click);
            // 
            // RunScriptButton
            // 
            this.RunScriptButton.Location = new System.Drawing.Point(919, 516);
            this.RunScriptButton.Name = "RunScriptButton";
            this.RunScriptButton.Size = new System.Drawing.Size(75, 23);
            this.RunScriptButton.TabIndex = 3;
            this.RunScriptButton.Text = "Run";
            this.RunScriptButton.UseVisualStyleBackColor = true;
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(742, 545);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(252, 23);
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
            this.ScriptsDataGrid.Location = new System.Drawing.Point(742, 304);
            this.ScriptsDataGrid.MultiSelect = false;
            this.ScriptsDataGrid.Name = "ScriptsDataGrid";
            this.ScriptsDataGrid.ReadOnly = true;
            this.ScriptsDataGrid.RowHeadersVisible = false;
            this.ScriptsDataGrid.RowTemplate.Height = 25;
            this.ScriptsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptsDataGrid.ShowCellToolTips = false;
            this.ScriptsDataGrid.ShowEditingIcon = false;
            this.ScriptsDataGrid.Size = new System.Drawing.Size(252, 165);
            this.ScriptsDataGrid.TabIndex = 1;
            this.ScriptsDataGrid.SelectionChanged += new System.EventHandler(this.ScriptsDataGrid_SelectionChanged);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(12, 275);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(466, 365);
            this.ConsoleTextBox.TabIndex = 4;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleLabel.Location = new System.Drawing.Point(12, 242);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(87, 30);
            this.ConsoleLabel.TabIndex = 0;
            this.ConsoleLabel.Text = "Console";
            // 
            // CommandLineTextBox
            // 
            this.CommandLineTextBox.Location = new System.Drawing.Point(12, 646);
            this.CommandLineTextBox.Name = "CommandLineTextBox";
            this.CommandLineTextBox.Size = new System.Drawing.Size(385, 23);
            this.CommandLineTextBox.TabIndex = 4;
            // 
            // SendCommandButton
            // 
            this.SendCommandButton.Location = new System.Drawing.Point(403, 646);
            this.SendCommandButton.Name = "SendCommandButton";
            this.SendCommandButton.Size = new System.Drawing.Size(75, 23);
            this.SendCommandButton.TabIndex = 3;
            this.SendCommandButton.Text = "Send";
            this.SendCommandButton.UseVisualStyleBackColor = true;
            // 
            // RefreshCommandsButton
            // 
            this.RefreshCommandsButton.Location = new System.Drawing.Point(661, 275);
            this.RefreshCommandsButton.Name = "RefreshCommandsButton";
            this.RefreshCommandsButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshCommandsButton.TabIndex = 3;
            this.RefreshCommandsButton.Text = "Refresh";
            this.RefreshCommandsButton.UseVisualStyleBackColor = true;
            this.RefreshCommandsButton.Click += new System.EventHandler(this.RefreshCommandsButton_Click);
            // 
            // RefreshScriptsButton
            // 
            this.RefreshScriptsButton.Location = new System.Drawing.Point(919, 275);
            this.RefreshScriptsButton.Name = "RefreshScriptsButton";
            this.RefreshScriptsButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshScriptsButton.TabIndex = 3;
            this.RefreshScriptsButton.Text = "Refresh";
            this.RefreshScriptsButton.UseVisualStyleBackColor = true;
            this.RefreshScriptsButton.Click += new System.EventHandler(this.RefreshScriptsButton_Click);
            // 
            // Bellatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.NewScriptButton);
            this.Controls.Add(this.SendCommandButton);
            this.Controls.Add(this.RefreshScriptsButton);
            this.Controls.Add(this.RefreshCommandsButton);
            this.Controls.Add(this.NewCommandButton);
            this.Controls.Add(this.RefreshDevicesButton);
            this.Controls.Add(this.ScriptCommandsDataGrid);
            this.Controls.Add(this.ScriptsDataGrid);
            this.Controls.Add(this.CommandsDataGrid);
            this.Controls.Add(this.DevicesDataGrid);
            this.Controls.Add(this.ScriptCommandsLabel);
            this.Controls.Add(this.ScriptsLabel);
            this.Controls.Add(this.ScriptDescLabel);
            this.Controls.Add(this.CommandDescLabel);
            this.Controls.Add(this.ScriptLabel);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.CommandsLabel);
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
        private TextBox ConsoleTextBox;
        private Label ConsoleLabel;
        private TextBox CommandLineTextBox;
        private Button SendCommandButton;
        private Button RefreshCommandsButton;
        private Button RefreshScriptsButton;
    }
}