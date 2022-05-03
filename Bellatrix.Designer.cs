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
            // Bellatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BellatrixLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Bellatrix";
            this.Text = "Bellatrix";
            this.Load += new System.EventHandler(this.Bellatrix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BellatrixLabel;
    }
}