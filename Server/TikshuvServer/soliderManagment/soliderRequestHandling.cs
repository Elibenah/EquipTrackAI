using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace TikshuvServer
{
    internal class soliderRequestHandling
    {
        public static Dictionary<int, List<string>> existingSoliders;
        public static List<soliderObject> existingSolidersList = new List<soliderObject>();

        //fix it
        public static void initSolidersToMemory()
        {
            existingSolidersList.Clear();
            soliderObject iterator = new soliderObject();
            existingSoliders = (Dictionary<int, List<string>>)DataBase.DataFromSave("soliders", "");
            foreach(List<string> soliderInDict in existingSoliders.Values)
            {
                iterator = new soliderObject();
                iterator.ID = soliderInDict[1];
                iterator.name= soliderInDict[2];
                iterator.familyName= soliderInDict[3];
                iterator.phoneNumber= soliderInDict[4];
                iterator.DateOfBirth= soliderInDict[5];
                iterator.premissionLevel = int.Parse(soliderInDict[6]);
                existingSolidersList.Add(iterator);
            }
        }
        public static object[] soliderRequestFromClient(requestObject request)
        {
            object[] array = new object[2];
            bool ifAccepted = false;
            switch (request.request)
            {
                case "getAllExistingSoliders":
                    ifAccepted = checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = existingSolidersList;
                    array[1] = true;
                    return array;
                    // code block
                    break;
                case "getPremission":
                    ifAccepted = checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = "";
                    array[1] = true;
                    return array;
                    // code block
                    break;
                case "updateSoliders":
                    ifAccepted = checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = "";
                    array[1] = true;
                    // code block
                    return array;
                case "addSolider":
                    ifAccepted = checkPremission(request.ID, 10);
                    ifAccepted = checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = "";
                    array[1] = true;
                    var solider = JsonConvert.DeserializeObject<soliderObject>(request.data.ToString());
                    // Check if a soldier with the same private number already exists
                    string checkQuery = "SELECT COUNT(*) FROM soliders WHERE privateNumber = @privateNumber";
                    SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, Program.mainDataBase.DBConnection);
                    checkCmd.Parameters.AddWithValue("@privateNumber", solider.ID);

                    //  Open the connection and check existence
                    Program.mainDataBase.OpenConnection();
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    //  Prepare a command object to be initialized later
                    SQLiteCommand cmd;

                    //  Determine whether to UPDATE or INSERT
                    if (exists > 0)
                    {
                        // Soldier already exists – perform UPDATE
                        string updateQuery = @"UPDATE soliders 
                           SET name = @name, familyname = @familyname, phoneNumber = @phoneNumber,
                               DateOfBirth = @DateOfBirth, premissionLevel = @premissionLevel
                           WHERE privateNumber = @privateNumber";
                        cmd = new SQLiteCommand(updateQuery, Program.mainDataBase.DBConnection);
                    }
                    else
                    {
                        // Soldier doesn't exist – perform INSERT
                        string insertQuery = @"INSERT INTO soliders (privateNumber, name, familyname, phoneNumber, DateOfBirth, premissionLevel)
                           VALUES (@privateNumber, @name, @familyname, @phoneNumber, @DateOfBirth, @premissionLevel)";
                        cmd = new SQLiteCommand(insertQuery, Program.mainDataBase.DBConnection);
                    }

                    //  Set shared parameters for both INSERT and UPDATE
                    cmd.Parameters.AddWithValue("@privateNumber", solider.ID);
                    cmd.Parameters.AddWithValue("@name", solider.name);
                    cmd.Parameters.AddWithValue("@familyname", solider.familyName);
                    cmd.Parameters.AddWithValue("@phoneNumber", solider.phoneNumber);
                    cmd.Parameters.AddWithValue("@DateOfBirth", solider.DateOfBirth);
                    cmd.Parameters.AddWithValue("@premissionLevel", solider.premissionLevel);

                    // Execute the command (either INSERT or UPDATE)
                    cmd.ExecuteNonQuery();

                    //  Close the database connection
                    Program.mainDataBase.CloseConnection();

                    //  Refresh server memory and notify all connected clients
                    initSolidersToMemory();
                    Server.broadcastUpdate("solider", "getAllExistingSoliders", existingSolidersList);

                    return array;

                    // code block
                    break;
                case "soliderConnection":
                    ifAccepted = checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = existingSolidersList;
                    array[1] = true;
                    return array;
                    break;
                default:
                    array[0] = "";
                    array[1] = false;
                    return array;
                    // code block
                    break;
            }
        }

        public static bool checkPremission(string personalNumber, int requiredPermission)
        {
            foreach(soliderObject user in existingSolidersList)
            {
                if((user.name.ToLower() == personalNumber.ToLower() || user.ID.ToLower() == personalNumber.ToLower()) && user.premissionLevel <= requiredPermission)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
