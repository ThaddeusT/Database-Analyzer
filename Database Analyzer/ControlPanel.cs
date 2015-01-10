using Database_Analyzer.Functions;
using Database_Analyzer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Analyzer
{
    public partial class ControlPanel : Form
    {
        #region Fields

        private Connection Connection1;
        private Connection Connection2;

        #endregion
        
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void TestConnection1_Click(object sender, EventArgs e)
        {
            Connection1 = new Connection(connection1TextBox.Text);
            if (SQLFunctions.TestConnectionToDatabase(Connection1))
            {
                MessageBox.Show("Test for Connection 1 Succeeded.");
            }
            else
            {
                MessageBox.Show("Test for Connection 1 Failed.");
            }
        }

        private void TestConnection2_Click(object sender, EventArgs e)
        {
            Connection2 = new Connection(connection2TextBox.Text);
            if (SQLFunctions.TestConnectionToDatabase(Connection2))
            {
                MessageBox.Show("Test for Connection 2 Succeeded.");
            }
            else
            {
                MessageBox.Show("Test for Connection 2 Failed.");
            }
        }
    }
}
