using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Analyzer.Models;
using System.Data.SqlClient;
using System.Data;

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

        #region Table Loading Functions

        public static List<String> LoadTablesForConnection(Connection Connection)
        {
            List<String> tables = new List<string>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                foreach (DataRow row in dt.Rows)
                {
                    if (row[3].ToString().Equals("BASE TABLE", StringComparison.OrdinalIgnoreCase)) //ignore views
                    {
                        string tableName = row[2].ToString();
                        tables.Add(tableName);
                    }
                }
            }
            return tables.OrderBy(x=>x).ToList();
        }

        public static String getPrimaryKeyForTable(String TableName, Connection Connection)
        {
            String primaryKey = "";
            DataTable primaryKeys = new DataTable();
            String Query = "SELECT c.name AS column_name FROM sys.indexes AS i INNER JOIN sys.index_columns AS ic"
            + " ON i.object_id = ic.object_id AND i.index_id = ic.index_id INNER JOIN sys.columns AS c ON ic.object_id = c.object_id"
            + " AND c.column_id = ic.column_id WHERE i.is_primary_key = 1 AND i.object_id = OBJECT_ID('" + TableName + "');";

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, connection);
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(primaryKeys);
                connection.Close();
                da.Dispose();
            }
            foreach (DataRow row in primaryKeys.Rows)
            {
                primaryKey = row.Field<string>(0);
            }
            return primaryKey;
        }

        public static List<DataTable> loadDataTables(String TableName, List<Connection> Connections, out String PK)
        {
            List<DataTable> tables = new List<DataTable>(){new DataTable(),new DataTable()};
            PK = getPrimaryKeyForTable(TableName, Connections[0]);
            String Query = "SELECT * FROM "+TableName+" ORDER BY "+PK;

            using (SqlConnection connection = new SqlConnection(Connections[0].ConnectionString))
            {
                tables[0] = new DataTable();
                SqlCommand cmd = new SqlCommand(Query, connection);
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tables[0]);
                connection.Close();
                da.Dispose();
            }

            using (SqlConnection connection = new SqlConnection(Connections[1].ConnectionString))
            {
                tables[1] = new DataTable();
                SqlCommand cmd = new SqlCommand(Query, connection);
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tables[1]);
                connection.Close();
                da.Dispose();
            }
            return tables;
        }

        #endregion
    }
}
