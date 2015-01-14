using Database_Analyzer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Analyzer.Functions
{
    public static class ComparisonFunctions
    {
        public static String CompareDataBases(List<String> Tables, List<Connection> Connections)
        {
            String results = "";
            for (int h = 0; h < Tables.Count; h++)
            {
                Dictionary<String, List<String>> tableValues1 = new Dictionary<string, List<string>>();
                Dictionary<String, List<String>> tableValues2 = new Dictionary<string, List<string>>();

                results += "Beginning comparison for " + Tables[h] + Environment.NewLine;
                String pK = "";
                List<DataTable> tables = SQLFunctions.loadDataTables(Tables[h], Connections, out pK);
                if (tables[0].Rows.Count != tables[1].Rows.Count)
                {
                    results += "The number of rows in each database for " + Tables[h] + " are not equal." + Environment.NewLine;
                }
                if (tables[0].Columns.Count != tables[1].Columns.Count)
                {
                    results += "The number of columns in each database for " + Tables[h] + " are not equal." + Environment.NewLine;
                }

                if ((tables[0].Rows.Count == tables[1].Rows.Count) && (tables[0].Columns.Count == tables[1].Columns.Count))
                {
                    foreach (DataRow row in tables[0].Rows)
                    {
                        List<String> record = new List<string>();
                        String pkValue = row[pK].ToString();
                        for (int i = 0; i < tables[0].Columns.Count; i++)
                        {
                            String value = row[i].ToString();
                            record.Add(value);
                        }
                        if (!tableValues1.ContainsKey(pkValue))
                        {
                            tableValues1.Add(pkValue, record);
                        }
                    }

                    foreach (DataRow row in tables[1].Rows)
                    {
                        List<String> record = new List<string>();
                        String pkValue = row[pK].ToString();
                        for (int i = 0; i < tables[1].Columns.Count; i++)
                        {
                            String value = row[i].ToString();
                            record.Add(value);
                        }
                        if (!tableValues2.ContainsKey(pkValue))
                        {
                            tableValues2.Add(pkValue, record);
                        }
                    }

                    for (int i = 0; i < tableValues1.Values.Count; i++)
                    {
                        List<String> columnsDifferent = new List<string>();
                        List<String> record1 = tableValues1.Values.ToList()[i];
                        List<String> record2 = tableValues2.Values.ToList()[i];
                        for (int j = 0; j < record1.Count; j++)
                        {
                            if (record1[j] != record2[j])
                            {
                                String columnName = tables[0].Columns[j].ColumnName;
                                columnsDifferent.Add(columnName);
                            }
                        }
                        if (columnsDifferent.Count > 0)
                        {
                            results += "Row with Primary Key: " + tableValues1.Keys.ToList()[i] + " is Different" + Environment.NewLine;
                            results += "Columns that are different: ";
                            string columns = "";
                            for (int k = 0; k < columnsDifferent.Count; k++)
                            {
                                if (k == columnsDifferent.Count - 1)
                                {
                                    columns += columnsDifferent[k] + Environment.NewLine;
                                }
                                else
                                {
                                    columns += columnsDifferent[k] + ", ";
                                }
                            }
                            results += columns;
                        }
                    }
                }

                results += "Comparison for " + Tables[h] + " complete." + Environment.NewLine;
                results += Environment.NewLine;
            }
            return results;
        }
    }
}
