namespace Database_Analyzer
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connection1TextBox = new System.Windows.Forms.TextBox();
            this.CNString1Label = new System.Windows.Forms.Label();
            this.TestConnection1Button = new System.Windows.Forms.Button();
            this.TestConnection2Button = new System.Windows.Forms.Button();
            this.CNString2Label = new System.Windows.Forms.Label();
            this.connection2TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfiguationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TablesInBothDatabasesListBox = new System.Windows.Forms.CheckedListBox();
            this.LoadTablesButton = new System.Windows.Forms.Button();
            this.TablesInBothDatabasesLabel = new System.Windows.Forms.Label();
            this.runComparison = new System.Windows.Forms.Button();
            this.comparisonList = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connection1TextBox
            // 
            this.connection1TextBox.Location = new System.Drawing.Point(200, 68);
            this.connection1TextBox.Multiline = true;
            this.connection1TextBox.Name = "connection1TextBox";
            this.connection1TextBox.Size = new System.Drawing.Size(825, 20);
            this.connection1TextBox.TabIndex = 0;
            // 
            // CNString1Label
            // 
            this.CNString1Label.AutoSize = true;
            this.CNString1Label.Location = new System.Drawing.Point(30, 71);
            this.CNString1Label.Name = "CNString1Label";
            this.CNString1Label.Size = new System.Drawing.Size(164, 13);
            this.CNString1Label.TabIndex = 1;
            this.CNString1Label.Text = "Connection String for Database 1";
            // 
            // TestConnection1Button
            // 
            this.TestConnection1Button.Location = new System.Drawing.Point(1051, 65);
            this.TestConnection1Button.Name = "TestConnection1Button";
            this.TestConnection1Button.Size = new System.Drawing.Size(111, 19);
            this.TestConnection1Button.TabIndex = 2;
            this.TestConnection1Button.Text = "Test Connection";
            this.TestConnection1Button.UseVisualStyleBackColor = true;
            this.TestConnection1Button.Click += new System.EventHandler(this.TestConnection1_Click);
            // 
            // TestConnection2Button
            // 
            this.TestConnection2Button.Location = new System.Drawing.Point(1051, 105);
            this.TestConnection2Button.Name = "TestConnection2Button";
            this.TestConnection2Button.Size = new System.Drawing.Size(111, 19);
            this.TestConnection2Button.TabIndex = 5;
            this.TestConnection2Button.Text = "Test Connection";
            this.TestConnection2Button.UseVisualStyleBackColor = true;
            this.TestConnection2Button.Click += new System.EventHandler(this.TestConnection2_Click);
            // 
            // CNString2Label
            // 
            this.CNString2Label.AutoSize = true;
            this.CNString2Label.Location = new System.Drawing.Point(30, 111);
            this.CNString2Label.Name = "CNString2Label";
            this.CNString2Label.Size = new System.Drawing.Size(164, 13);
            this.CNString2Label.TabIndex = 4;
            this.CNString2Label.Text = "Connection String for Database 2";
            // 
            // connection2TextBox
            // 
            this.connection2TextBox.Location = new System.Drawing.Point(200, 108);
            this.connection2TextBox.Multiline = true;
            this.connection2TextBox.Name = "connection2TextBox";
            this.connection2TextBox.Size = new System.Drawing.Size(825, 20);
            this.connection2TextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigurationToolStripMenuItem,
            this.saveConfiguationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Load Configuration";
            this.loadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.loadConfiguration_Click);
            // 
            // saveConfiguationToolStripMenuItem
            // 
            this.saveConfiguationToolStripMenuItem.Name = "saveConfiguationToolStripMenuItem";
            this.saveConfiguationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveConfiguationToolStripMenuItem.Text = "Save Configuation";
            this.saveConfiguationToolStripMenuItem.Click += new System.EventHandler(this.saveConfiguation_Click);
            // 
            // TablesInBothDatabasesListBox
            // 
            this.TablesInBothDatabasesListBox.Enabled = false;
            this.TablesInBothDatabasesListBox.FormattingEnabled = true;
            this.TablesInBothDatabasesListBox.Location = new System.Drawing.Point(33, 198);
            this.TablesInBothDatabasesListBox.Name = "TablesInBothDatabasesListBox";
            this.TablesInBothDatabasesListBox.Size = new System.Drawing.Size(264, 334);
            this.TablesInBothDatabasesListBox.TabIndex = 7;
            this.TablesInBothDatabasesListBox.Visible = false;
            this.TablesInBothDatabasesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TablesInBothDatabasesListBox_ItemCheck);
            // 
            // LoadTablesButton
            // 
            this.LoadTablesButton.Enabled = false;
            this.LoadTablesButton.Location = new System.Drawing.Point(186, 169);
            this.LoadTablesButton.Name = "LoadTablesButton";
            this.LoadTablesButton.Size = new System.Drawing.Size(111, 21);
            this.LoadTablesButton.TabIndex = 9;
            this.LoadTablesButton.Text = "Load Tables";
            this.LoadTablesButton.UseVisualStyleBackColor = true;
            this.LoadTablesButton.Click += new System.EventHandler(this.LoadTablesButton_Click);
            // 
            // TablesInBothDatabasesLabel
            // 
            this.TablesInBothDatabasesLabel.AutoSize = true;
            this.TablesInBothDatabasesLabel.Location = new System.Drawing.Point(30, 173);
            this.TablesInBothDatabasesLabel.Name = "TablesInBothDatabasesLabel";
            this.TablesInBothDatabasesLabel.Size = new System.Drawing.Size(129, 13);
            this.TablesInBothDatabasesLabel.TabIndex = 10;
            this.TablesInBothDatabasesLabel.Text = "Tables in Both Databases";
            // 
            // runComparison
            // 
            this.runComparison.Enabled = false;
            this.runComparison.Location = new System.Drawing.Point(329, 334);
            this.runComparison.Name = "runComparison";
            this.runComparison.Size = new System.Drawing.Size(108, 33);
            this.runComparison.TabIndex = 11;
            this.runComparison.Text = "Run Comparison";
            this.runComparison.UseVisualStyleBackColor = true;
            this.runComparison.Click += new System.EventHandler(this.runComparison_Click);
            // 
            // comparisonList
            // 
            this.comparisonList.Location = new System.Drawing.Point(476, 198);
            this.comparisonList.Name = "comparisonList";
            this.comparisonList.ReadOnly = true;
            this.comparisonList.Size = new System.Drawing.Size(713, 322);
            this.comparisonList.TabIndex = 12;
            this.comparisonList.Text = "";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 544);
            this.Controls.Add(this.comparisonList);
            this.Controls.Add(this.runComparison);
            this.Controls.Add(this.TablesInBothDatabasesLabel);
            this.Controls.Add(this.LoadTablesButton);
            this.Controls.Add(this.TablesInBothDatabasesListBox);
            this.Controls.Add(this.TestConnection2Button);
            this.Controls.Add(this.CNString2Label);
            this.Controls.Add(this.connection2TextBox);
            this.Controls.Add(this.TestConnection1Button);
            this.Controls.Add(this.CNString1Label);
            this.Controls.Add(this.connection1TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlPanel";
            this.Text = "Database Analyzer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox connection1TextBox;
        private System.Windows.Forms.Label CNString1Label;
        private System.Windows.Forms.Button TestConnection1Button;
        private System.Windows.Forms.Button TestConnection2Button;
        private System.Windows.Forms.Label CNString2Label;
        private System.Windows.Forms.TextBox connection2TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfiguationToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox TablesInBothDatabasesListBox;
        private System.Windows.Forms.Button LoadTablesButton;
        private System.Windows.Forms.Label TablesInBothDatabasesLabel;
        private System.Windows.Forms.Button runComparison;
        private System.Windows.Forms.RichTextBox comparisonList;
    }
}

