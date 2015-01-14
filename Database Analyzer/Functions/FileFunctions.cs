using Database_Analyzer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Database_Analyzer.Functions
{
    public static class FileFunctions
    {
        #region Fields

        private static String fileName = "TestConfiguration.TTT";

        #endregion

        #region Verify Configuration File Exists

        public static Boolean ConfigurationFileExists()
        {
            string path = Directory.GetCurrentDirectory();
            string pathString = System.IO.Path.Combine(path, fileName);
            return File.Exists(pathString);
        }

        #endregion

        #region Create Testing Configuration File Functions

        public static void CreateTestingConfigurationFile(Connection connection1, Connection connection2)
        {
            List<object> list = new List<object>();
            list.Add(connection1);
            list.Add(connection2);
            string path = Directory.GetCurrentDirectory();
            string pathString = System.IO.Path.Combine(path, fileName);
            if(File.Exists(pathString))
            {
                File.Delete(pathString);
            }
            SerializeList(list, pathString);
        }

        public static List<Connection> LoadTestingConfiguaration(Connection connection1, Connection connection2)
        {
            List<Object> list = new List<object>();
            List<Connection> connections = new List<Connection>();
            string path = Directory.GetCurrentDirectory();
            string pathString = System.IO.Path.Combine(path, fileName);
            list = DeSerializeList(pathString);
            connections.Add((Connection)list[0]);
            connections.Add((Connection)list[1]);
            return connections;
        }

        #endregion

        #region Serialization Functions

        private static void SerializeList(List<Object> Targets, string TargetPath)
        {

            IFormatter Formatter = new BinaryFormatter();

            using (FileStream OutputStream = System.IO.File.Create(TargetPath))
            {
                try
                {
                    Formatter.Serialize(OutputStream, Targets);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                }
            }

        }

        private static List<Object> DeSerializeList(string TargetPath)
        {
            List<Object> Targets = new List<object>();
            using (FileStream InputStream = new FileStream(TargetPath,FileMode.Open))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Targets = (List<Object>)formatter.Deserialize(InputStream);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + ex.Message);
                }
            }
            return Targets;
        }

        #endregion
    }
}
