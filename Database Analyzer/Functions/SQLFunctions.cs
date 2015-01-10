using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Analyzer.Models;
using System.Data.SqlClient;

namespace Database_Analyzer.Functions
{
    public static class SQLFunctions
    {
        #region Fields
        #endregion

        #region Connection Testing Fuctions

        public static Boolean TestConnectionToDatabase(String ConnectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean TestConnectionToDatabase(Connection Connection)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
