using MySql.Data.MySqlClient;
using System;

namespace MySqlHelper
{
    public class DbHelper
    {
        private const string Server = "37.140.192.191";
        private const string DatabaseName = "u1486803_FarpostWorkerBase";
        private const string UserName = "u1486803_wfbaseu";
        private const string Password = "rS0yD3lP2aeF4qN7";

        public readonly MySqlConnection Connection;

        public DbHelper(MySqlConnection connection)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public DbHelper()
            : this(new MySqlConnection($"Server={Server}; database={DatabaseName}; UID={UserName}; password={Password};CharSet=UTF8;"))
        {
        }

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {

            }
            else
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {

            }
            else
            {
                Connection.Close();
            }
        }

        // For Insert, Update or Delete queries
        public void ExecuteNonQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public int ExecuteSimpleQueryAsInt(string query)
        {
            return int.Parse(ExecuteSimpleQueryAsString(query));
        }

        public string ExecuteSimpleQueryAsString(string query)
        {
            return ExecuteSimpleQuery(query).ToString();
        }

        private object ExecuteSimpleQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                _ = cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Incorrect command?");
                    }
                    return reader.GetValue(0);
                }
            }
        }
    }
}
