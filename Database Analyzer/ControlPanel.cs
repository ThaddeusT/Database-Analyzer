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
            loadConfigurationToolStripMenuItem.Enabled = FileFunctions.ConfigurationFileExists();
            Connection1 = new Connection();
            Connection2 = new Connection();
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
                if (SQLFunctions.TestConnectionToDatabase(Connection1))
                {
                    LoadTablesButton.Enabled = true;
                }
                else
                {
                    LoadTablesButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Test for Connection 2 Failed.");
            }
        }

        private void loadConfiguration_Click(object sender, EventArgs e)
        {
            List<Connection> connections = FileFunctions.LoadTestingConfiguaration(Connection1, Connection2);
            Connection1.ConnectionString = connections[0].ConnectionString;
            Connection2.ConnectionString = connections[1].ConnectionString;
            connection1TextBox.Text = Connection1.ConnectionString;
            connection2TextBox.Text = Connection2.ConnectionString;
        }

        private void saveConfiguation_Click(object sender, EventArgs e)
        {
            Connection1.ConnectionString = connection1TextBox.Text;
            Connection2.ConnectionString = connection2TextBox.Text;
            FileFunctions.CreateTestingConfigurationFile(Connection1, Connection2);
            loadConfigurationToolStripMenuItem.Enabled = FileFunctions.ConfigurationFileExists();
        }

        private void LoadTablesButton_Click(object sender, EventArgs e)
        {
            List<String> TablesForConnection1 = SQLFunctions.LoadTablesForConnection(Connection1);
            List<String> TablesForConnection2 = SQLFunctions.LoadTablesForConnection(Connection2);
            foreach (String table in TablesForConnection1)
            {
                if (TablesForConnection2.Contains(table))
                {
                    TablesInBothDatabasesListBox.Items.Add(table, false);
                }
            }
            TablesInBothDatabasesListBox.Visible = true;
            TablesInBothDatabasesListBox.Enabled = true;
        }

        private void runComparison_Click(object sender, EventArgs e)
        {
            List<string> tables = TablesInBothDatabasesListBox.CheckedItems.Cast<string>().ToList();
            comparisonList.Text = ComparisonFunctions.CompareDataBases(tables, new List<Connection>() { Connection1, Connection2 });
        }

        private void TablesInBothDatabasesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (TablesInBothDatabasesListBox.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked)
            {
                runComparison.Enabled = false;
            }
            else
            {
                runComparison.Enabled = true;
            }
        }

    }
}
