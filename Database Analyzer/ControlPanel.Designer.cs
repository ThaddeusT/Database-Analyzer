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
            this.SuspendLayout();
            // 
            // connection1TextBox
            // 
            this.connection1TextBox.Location = new System.Drawing.Point(200, 68);
            this.connection1TextBox.Multiline = true;
            this.connection1TextBox.Name = "connection1TextBox";
            this.connection1TextBox.Size = new System.Drawing.Size(573, 20);
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
            this.TestConnection1Button.Location = new System.Drawing.Point(791, 68);
            this.TestConnection1Button.Name = "TestConnection1Button";
            this.TestConnection1Button.Size = new System.Drawing.Size(111, 19);
            this.TestConnection1Button.TabIndex = 2;
            this.TestConnection1Button.Text = "Test Connection";
            this.TestConnection1Button.UseVisualStyleBackColor = true;
            this.TestConnection1Button.Click += new System.EventHandler(this.TestConnection1_Click);
            // 
            // TestConnection2Button
            // 
            this.TestConnection2Button.Location = new System.Drawing.Point(791, 108);
            this.TestConnection2Button.Name = "TestConnection2Button";
            this.TestConnection2Button.Size = new System.Drawing.Size(111, 19);
            this.TestConnection2Button.TabIndex = 5;
            this.TestConnection2Button.Text = "Test Connection";
            this.TestConnection2Button.UseVisualStyleBackColor = true;
            this.TestConnection2Button.Click += new System.EventHandler(this.TestConnection2Button_Click);
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
            this.connection2TextBox.Size = new System.Drawing.Size(573, 20);
            this.connection2TextBox.TabIndex = 3;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 544);
            this.Controls.Add(this.TestConnection2Button);
            this.Controls.Add(this.CNString2Label);
            this.Controls.Add(this.connection2TextBox);
            this.Controls.Add(this.TestConnection1Button);
            this.Controls.Add(this.CNString1Label);
            this.Controls.Add(this.connection1TextBox);
            this.Name = "ControlPanel";
            this.Text = "Database Analyzer";
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
    }
}

