using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SQLite;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Text.Json;

namespace TikshuvServer
{
    public class DataBase
    {
        public SQLiteConnection DBConnection;
        public static bool WasExist = true;
        public DataBase(string source = "Files/mainDataBase.db")
        {
            if(!Directory.Exists("./Files"))
            {
                Directory.CreateDirectory("./Files");
            }
            DBConnection = new SQLiteConnection("Data source = ./" +source);
            if(!(File.Exists("./" + source)))
            {
                SQLiteConnection.CreateFile("./" + source);
                WasExist = false;
            }
        }
        public void OpenConnection()
        {
            if(DBConnection.State != System.Data.ConnectionState.Open)
            {
                DBConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (DBConnection.State != System.Data.ConnectionState.Closed)
            {
                DBConnection.Close();
            }
        }

        public static void initDataBase()
        {

            string query = "";
            
            SQLiteCommand setNewData = new SQLiteCommand();
            Program.mainDataBase.OpenConnection();

            // We will always make sure that the table exists (even if the file already exists)
            string createSolidersTable = @"CREATE TABLE IF NOT EXISTS soliders (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        privateNumber TEXT,
        name TEXT,
        familyname TEXT,
        phoneNumber TEXT,
        DateOfBirth TEXT,
        premissionLevel INT
    )";
            SQLiteCommand cmd = new SQLiteCommand(createSolidersTable, Program.mainDataBase.DBConnection);
            cmd.ExecuteNonQuery();
            string createSignatureTable = @"
        CREATE TABLE IF NOT EXISTS signatures (
            signingPerson TEXT,
            signingPersonNumber TEXT,
            stampeerPerson TEXT,
            stampeerPersonNumber TEXT,
            missionName TEXT,
            missionId TEXT PRIMARY KEY,
            signatureBase64 TEXT,
            isSigned INTEGER,
            date TEXT
        );";
            cmd = new SQLiteCommand(createSignatureTable, Program.mainDataBase.DBConnection);
            cmd.ExecuteNonQuery();
            if (!WasExist)
            {
                Program.mainDataBase.OpenConnection();
                string TableSession = "CREATE TABLE session (id INTEGER PRIMARY KEY AUTOINCREMENT, type TEXT, data TEXT)";
                SQLiteCommand TableCreator = new SQLiteCommand(TableSession, Program.mainDataBase.DBConnection);
                TableCreator.ExecuteNonQuery();

                query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                setNewData.Parameters.AddWithValue("@type", "equipment");
                setNewData.Parameters.AddWithValue("@data", "[]");
                setNewData.ExecuteNonQuery();

                query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                setNewData.Parameters.AddWithValue("@type", "items");
                setNewData.Parameters.AddWithValue("@data", "{}");
                setNewData.ExecuteNonQuery();

                query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                setNewData.Parameters.AddWithValue("@type", "missionsList");
                setNewData.Parameters.AddWithValue("@data", "[]");
                setNewData.ExecuteNonQuery();

                query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                setNewData.Parameters.AddWithValue("@type", "attachment");
                setNewData.Parameters.AddWithValue("@data", "[]");
                setNewData.ExecuteNonQuery();

                query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                setNewData.Parameters.AddWithValue("@type", "historyMissions");
                setNewData.Parameters.AddWithValue("@data", "[]");
                setNewData.ExecuteNonQuery();

                string usersTable = @"CREATE TABLE IF NOT EXISTS soliders (
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        privateNumber TEXT,
                                                        name TEXT,
                                                        familyname TEXT,
                                                        phoneNumber TEXT,
                                                        DateOfBirth TEXT,
                                                        premissionLevel INT
                                                        )";
                TableCreator = new SQLiteCommand(usersTable, Program.mainDataBase.DBConnection);
                TableCreator.ExecuteNonQuery();

                Console.WriteLine("Trying to insert first admin");

                string userName = Environment.UserName;
                string addFirstAdmin = string.Format(
                    "INSERT INTO soliders (privateNumber, name, familyname, phoneNumber, DateOfBirth, premissionLevel) " +
                    "VALUES('1111111', '{0}', 'NaN', '000000000', '8/5/2001', '1')", userName);

                SQLiteCommand insertAdmin = new SQLiteCommand(addFirstAdmin, Program.mainDataBase.DBConnection);
                //insertAdmin.ExecuteNonQuery();
                TableCreator = new SQLiteCommand(addFirstAdmin, Program.mainDataBase.DBConnection); // 
                //insertAdminCommand 
                // Create the Attachments table if it doesn't exist
                string createAttachmentsTable = @"
                                                CREATE TABLE IF NOT EXISTS Attachments (
                                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                    name TEXT NOT NULL,
                                                    description TEXT,
                                                    type TEXT,
                                                    dateAdded TEXT,
                                                    equipmentId INTEGER
                                                )";
                SQLiteCommand createAttachmentsCmd = new SQLiteCommand(createAttachmentsTable, Program.mainDataBase.DBConnection);
                createAttachmentsCmd.ExecuteNonQuery();
             
                TableCreator.ExecuteNonQuery();

                Program.mainDataBase.CloseConnection();
            }
            Program.mainDataBase.CloseConnection();

        }
        public static bool checkIfExists(string dataType)
        {
            bool exists = false;
            Program.mainDataBase.OpenConnection();
            string query = "SELECT type FROM session";
            SQLiteCommand myCommand = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (result["type"].ToString().Equals(dataType))
                    {
                        exists = true;
                    }
                }
            }
            Program.mainDataBase.CloseConnection();
            return exists;
        }
        /// <summary>
        /// typeOfData - equipment or items or missionsList or historyMissions
        /// </summary>
        public static bool updateDataBaseObjects(string typeOfData, object dataToWrite)
        {
            
            string query = "";
            try
            {
                SQLiteCommand setNewData;

                if (checkIfExists(typeOfData))
                {

                    query = "UPDATE session SET data=@data WHERE type = @a2";
                    setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                    setNewData.Parameters.AddWithValue("a2", typeOfData);
                }
                else
                {
                    query = "INSERT INTO session ('type', 'data') VALUES (@type, @data)";
                    setNewData = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                    setNewData.Parameters.AddWithValue("@type", typeOfData);
                }
                Program.mainDataBase.OpenConnection();
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = System.Text.Json.JsonSerializer.Serialize(dataToWrite, options);
                setNewData.Parameters.AddWithValue("@data", jsonString);
                setNewData.ExecuteNonQuery();
                Program.mainDataBase.CloseConnection();
                return true;
            }
            catch (Exception e)

            {
                return false;
            }
        }
        /// <summary>
        /// table could be soliders or session
        /// </summary>
        /// <param name="table"></param>
        /// <param name="typeOfData"></param>
        /// <returns></returns>
        public static object DataFromSave(string table,string typeOfData)
        {
            object dataFromDataBase = null;
            string query; 
            SQLiteCommand myCommand;
            Program.mainDataBase.OpenConnection();
            if(typeOfData.Equals(""))
            {
                dataFromDataBase = new Dictionary<int, List<string>>();
                query = "SELECT * FROM " + table;
                myCommand = new SQLiteCommand(query, Program.mainDataBase.DBConnection);

                SQLiteDataReader result = myCommand.ExecuteReader();
                int j = 0;
                if (result.HasRows)
                {
                    
                    while (result.Read())
                    {
                        ((Dictionary<int, List<string>>)dataFromDataBase).Add(j, new List<string>());
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            //dataFromDataBase += result[i].ToString() + " ";
                            ((Dictionary<int, List<string>>)dataFromDataBase)[j].Add(result[i].ToString());
                        }
                        j++;
                    }
                }
            }
            else
            {
                query = "SELECT * FROM " + table + " WHERE type =@a2";
                myCommand = new SQLiteCommand(query, Program.mainDataBase.DBConnection);
                myCommand.Parameters.AddWithValue("a2", typeOfData);

                SQLiteDataReader result = myCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        dataFromDataBase = result["data"].ToString();
                    }
                }
            }
            
            
            string type = dataFromDataBase.GetType().Name;
            Program.mainDataBase.CloseConnection();
            return dataFromDataBase;
        }
    }
}
