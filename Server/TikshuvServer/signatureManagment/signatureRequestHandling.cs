using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikshuvServer.signatureManagment
{
    public class signatureRequestHandling
    {
        public static List<signatureObject> AllSignature = new List<signatureObject>();
        public static void initSignatureToMemory()
        {
            string dbPath = "Files/mainDataBase.db";
            string connectionString = $"Data Source={dbPath};Version=3;";
            AllSignature = new List<signatureObject>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM signatures";
                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var signature = new signatureObject
                        {
                            signingPerson = reader["signingPerson"].ToString(),
                            signingPersonNumber = reader["signingPersonNumber"].ToString(),
                            stampeerPerson = reader["stampeerPerson"].ToString(),
                            stampeerPersonNumber = reader["stampeerPersonNumber"].ToString(),
                            missionName = reader["missionName"].ToString(),
                            missionId = reader["missionId"].ToString(),
                            signatureBase64 = reader["signatureBase64"].ToString(),
                            isSigned = Convert.ToInt32(reader["isSigned"]) == 1
                        };

                        AllSignature.Add(signature);
                    }
                }

                connection.Close();
            }
        }
        public static void saveSignatureToDataBase()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "mainDataBase.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
            INSERT OR REPLACE INTO signatures (
                missionId,
                signingPerson,
                signingPersonNumber,
                stampeerPerson,
                stampeerPersonNumber,
                missionName,
                signatureBase64,
                isSigned
            )
            VALUES (
                @missionId,
                @signingPerson,
                @signingPersonNumber,
                @stampeerPerson,
                @stampeerPersonNumber,
                @missionName,
                @signatureBase64,
                @isSigned
            );
        ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    foreach (var sig in AllSignature)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@missionId", sig.missionId);
                        command.Parameters.AddWithValue("@signingPerson", sig.signingPerson);
                        command.Parameters.AddWithValue("@signingPersonNumber", sig.signingPersonNumber);
                        command.Parameters.AddWithValue("@stampeerPerson", sig.stampeerPerson);
                        command.Parameters.AddWithValue("@stampeerPersonNumber", sig.stampeerPersonNumber);
                        command.Parameters.AddWithValue("@missionName", sig.missionName);
                        command.Parameters.AddWithValue("@signatureBase64", sig.signatureBase64);
                        command.Parameters.AddWithValue("@isSigned", sig.isSigned ? 1 : 0);

                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }
        public static bool DeleteSignature(requestObject request)
        {
            string missionIdToDelete = request.data.ToString();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "mainDataBase.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM signatures WHERE missionId = @missionId";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@missionId", missionIdToDelete);
                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        Console.WriteLine($"No signature found with missionId '{missionIdToDelete}'.");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine($"Deleted signature with missionId '{missionIdToDelete}'.");
                        return true;
                    }
                }

                connection.Close();
                //initSignatureToMemory();
                saveSignatureToDataBase();
                missionRequestHandling.UnsignedMissionBySignature(missionIdToDelete);
            }
        }
        public static signatureObject GetSignature(requestObject request)
        {

            string missionId = request.data.ToString();
            return AllSignature.FirstOrDefault(s => s.missionId == missionId);
        }
        public static List<object> GetMissionSummaries()
        {
            return AllSignature
                .Select(s => new
                {
                    s.missionId,
                    s.missionName,
                    s.isSigned
                })
                .Cast<object>()
                .ToList();
        }
        public static bool UpsertSignature(requestObject request)
        {
            signatureObject newSignature = JObject.Parse(request.data.ToString()).ToObject<signatureObject>();
            //Signature newSignature
            // Find index of existing signature with the same missionId
            int index = AllSignature.FindIndex(s => s.missionId == newSignature.missionId);

            if (index != -1)
            {
                // Replace existing signature
                AllSignature[index] = newSignature;
            }
            else
            {
                // Add new signature to the list
                AllSignature.Add(newSignature);
            }
            saveSignatureToDataBase();
            missionRequestHandling.SignMissionBySignature(newSignature.missionId);
            return true;
        }
        public static object[] signatureRequestFromClient(requestObject request)
        {
            object[] array = new object[2];
            bool ifAccepted = false;
            switch (request.request)
            {
                case "UpsertSignature":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = UpsertSignature(request);
                    array[1] = true;
                    return array;
                case "GetMissionSummaries":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = GetMissionSummaries();
                    array[1] = true;
                    return array;
                case "GetSignature":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = GetSignature(request);
                    array[1] = true;
                    return array;
                case "DeleteSignature":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = DeleteSignature(request);
                    array[1] = true;
                    return array;
                default:
                    break;
            }
            return array;
        }
    }
}
