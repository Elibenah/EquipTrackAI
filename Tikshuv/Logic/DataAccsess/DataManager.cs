using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace Tikshuv.Logic.DataAccess
{
    public class DataManager : IDisposable
    {
        private SQLiteConnection _connection;
        private const string ConnectionString = "Data source = ./LocalDB.db";
        public SQLiteConnection Connection { get; private set; }
        public DataManager()
        {
            _connection = new SQLiteConnection(ConnectionString);
            Connection = _connection;
            OpenConnection();
        }

        private void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Debug.WriteLine(query);
                using (SQLiteCommand cmd = new SQLiteCommand(query, _connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ExecuteQuery: {ex.Message}");
            }
            
            return dt;
        }
        public DataTable ExecuteParameterizedQuery(string query, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, _connection))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ExecuteParameterizedQuery: {ex.Message}");
            }

            return dt;
        }
        public void Dispose()
        {
            CloseConnection();
        }

    }
}
