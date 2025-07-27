using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TikshuvServer.equipmentManagment;
using System.Data.SQLite;



namespace TikshuvServer
{

    internal class equipmentRequestHandling
    {
        public static string equipmentDataBase;
        public static string existItemsByTypeDataBase;
        public static string existAttachmentDataBase;

        public static List<Equipment> existsEquipmentsList = new List<Equipment>();//Equipment
        public static Dictionary<string, List<Equipment>> existItemsByType = new Dictionary<string, List<Equipment>>();
        public static List<Attachment> existingAttachments = new List<Attachment>();
        public static void initEquipmentToMemory()
        {
            equipmentDataBase = DataBase.DataFromSave("session","equipment").ToString();
            existItemsByTypeDataBase = DataBase.DataFromSave("session","items").ToString();
            existAttachmentDataBase = DataBase.DataFromSave("session", "attachment").ToString();

            if (equipmentDataBase != "")
            {
                existsEquipmentsList = JsonConvert.DeserializeObject<List<Equipment>>(equipmentDataBase.ToString());
            }

            if (existItemsByTypeDataBase != "")
            {
                existItemsByType = JsonConvert.DeserializeObject<Dictionary<string, List<Equipment>>>(existItemsByTypeDataBase.ToString());
            }
            if (existAttachmentDataBase != "")
            {
                existingAttachments = JsonConvert.DeserializeObject<List<Attachment>>(existAttachmentDataBase.ToString());
            }
        }
        public static object[] equipmentRequestFromClient(requestObject request)
        {
            object[] array = new object[2];
            bool ifAccepted = false;
            switch (request.request)
            {
                case "getExistsEquipmentsList":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = existsEquipmentsList;
                    array[1] = true;
                    return array;
                case "getExistingEquipmentByType":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if(!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = existItemsByType;
                    array[1] = true;
                    return array;
                    // code block
                    break;
                case "updateEquipment":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = updateEntityEquipment(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getExistsEquipmentsList", existsEquipmentsList);
                    Server.broadcastUpdate(request.requestSubject, "getExistingEquipmentByType", existItemsByType);
                    // code block
                    break;
                case "addEquipment":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    
                    array[0] = updateExistsEquipment(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getExistsEquipmentsList", existsEquipmentsList);
                    Server.broadcastUpdate(request.requestSubject, "getExistingEquipmentByType", existItemsByType);
                    return array;
                // code block
                case "addItemsToEquipment":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = updateExistsItems(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getExistsEquipmentsList", existsEquipmentsList);
                    Server.broadcastUpdate(request.requestSubject, "getExistingEquipmentByType", existItemsByType);
                    break;

                case "getExistsAttachmentList":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = existingAttachments;
                    array[1] = true;
                    return array;
                case "addAttachment":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = addAttachment(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getExistsAttachmentList", existingAttachments);
                    return array;
                case "deleteItem":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = deleteItem(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getExistingEquipmentByType", existingAttachments);
                    return array;
                default:
                    // code block
                    break;
            }
            return array;
        }

        private static string updateEntityEquipment(requestObject request)
        {
            Equipment newItem = new Equipment();
            newItem = JObject.Parse(request.data.ToString()).ToObject<Equipment>();
            newItem.lastChange = DateTime.Now;
            for (int i = 0; i < existsEquipmentsList.Count; i++)
            {
                if (existsEquipmentsList[i].type == newItem.type)
                {
                    existsEquipmentsList[i] = newItem;
                    break;
                }
            }
            DataBase.updateDataBaseObjects("equipment", existsEquipmentsList);

            if (existItemsByType.ContainsKey(newItem.type))
            {
                for(int i = 0; i < existItemsByType[newItem.type].Count; i++)
                {

                    existItemsByType[newItem.type][i].Addons = newItem.Addons;
                    foreach (var item in newItem.Addons)
                    {
                        if (!existItemsByType[newItem.type][i].Addons.Contains(item))
                        {
                            existItemsByType[newItem.type][i].Addons.Add(item);
                        }
                    }


                    foreach (var key in newItem.specialAttributes.Keys)
                    {
                        if (!existItemsByType[newItem.type][i].specialAttributes.ContainsKey(key))
                        {
                            existItemsByType[newItem.type][i].specialAttributes[key] = null;
                        }
                    }
                }
                DataBase.updateDataBaseObjects("items", existItemsByType);
                return "ok";
            }
            return "empty";
        }

        public static string updateExistsEquipment(requestObject request)
        {
            Equipment newItem = JObject.Parse(request.data.ToString()).ToObject<Equipment>();
            newItem.lastChange = DateTime.Now;

            // Check if type already exists
            if (!existItemsByType.ContainsKey(newItem.type))
            {
                existItemsByType.Add(newItem.type, new List<Equipment>());
                existsEquipmentsList.Add(newItem);

                // Save to in-memory structures (as before)
                DataBase.updateDataBaseObjects("items", existItemsByType);
                DataBase.updateDataBaseObjects("equipment", existsEquipmentsList);

                // Optional: Save also to SQLite DB
                try
                {
                    Program.mainDataBase.OpenConnection();

                    string insertQuery = @"INSERT INTO Equipments 
                (type, lastChange, addonsJson, attributesJson) 
                VALUES (@type, @lastChange, @addons, @attributes)";

                    string addonsJson = JsonConvert.SerializeObject(newItem.Addons ?? new List<Attachment>());
                    string attributesJson = JsonConvert.SerializeObject(newItem.specialAttributes ?? new Dictionary<string, object>());

                    var cmd = new SQLiteCommand(insertQuery, Program.mainDataBase.DBConnection);
                    cmd.Parameters.AddWithValue("@type", newItem.type);
                    cmd.Parameters.AddWithValue("@lastChange", newItem.lastChange);
                    cmd.Parameters.AddWithValue("@addons", addonsJson);
                    cmd.Parameters.AddWithValue("@attributes", attributesJson);

                    cmd.ExecuteNonQuery();
                    Program.mainDataBase.CloseConnection();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB Insert Error: " + ex.Message);
                    // Optionally log the error or return a failure status
                }

                return "ok";
            }
            else
            {
                return "already exist";
            }
        }

        public static string updateExistsItems(requestObject request)
        {
            Equipment addedItem = new Equipment();
            addedItem = JObject.Parse(request.data.ToString()).ToObject<Equipment>();
            bool existed = false;
            if (addedItem.specialAttributes.ContainsKey("תוספות"))
            {
                addedItem.specialAttributes["תוספות"] = ((JArray)addedItem.specialAttributes["תוספות"]).ToObject<List<Attachment>>();
            }
            if (existItemsByType.ContainsKey(addedItem.type))
            {
                for(int i = 0; i < existItemsByType[addedItem.type].Count;i++)
                {
                    if (existItemsByType[addedItem.type][i].serialNumber == addedItem.serialNumber && (addedItem.serialNumber.ToLower() != "n\\a" || addedItem.serialNumber.ToLower() != "n/a"))
                    {
                        existItemsByType[addedItem.type][i] = addedItem;
                        existed = true;
                        DataBase.updateDataBaseObjects("items", existItemsByType);
                        return "ok";
                    }
                }
                if(!existed)
                {
                    existItemsByType[addedItem.type].Add(addedItem);
                    DataBase.updateDataBaseObjects("items", existItemsByType);
                    return "ok";
                }
            }
            else
            {
                existItemsByType.Add(addedItem.type, new List<Equipment>() { addedItem });
                DataBase.updateDataBaseObjects("items", existItemsByType);
            }
            return "ok";
        }
        public static string addAttachment(requestObject request)
        {
            Attachment newAttachment = JObject.Parse(request.data.ToString()).ToObject<Attachment>();

            // Check if it already exists in the list in memory
            if (existingAttachments.Any(a => a.name == newAttachment.name))
            return "already exist";

            // add to memory (optional)
            existingAttachments.Add(newAttachment);

            // Add to database
            Program.mainDataBase.OpenConnection();

            string insert = "INSERT INTO Attachments (name, description, type, dateAdded, equipmentId) " +
                            "VALUES (@name, @desc, @type, @date, @equipmentId)";

            var cmd = new SQLiteCommand(insert, Program.mainDataBase.DBConnection);
            cmd.Parameters.AddWithValue("@name", newAttachment.name);
            cmd.Parameters.AddWithValue("@desc", newAttachment.description ?? "");
            cmd.Parameters.AddWithValue("@type", newAttachment.type ?? "אחר");
            cmd.Parameters.AddWithValue("@date", newAttachment.dateAdded.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@equipmentId", newAttachment.equipmentId ?? (object)DBNull.Value);

            cmd.ExecuteNonQuery();

            Program.mainDataBase.CloseConnection();

            return "ok";
        }
        public static string deleteItem(requestObject request)
        {

            Equipment sendedItem = new Equipment();
            sendedItem = JObject.Parse(request.data.ToString()).ToObject<Equipment>();
            if (equipmentRequestHandling.existItemsByType.ContainsKey(sendedItem?.type))
            {
                equipmentRequestHandling.existItemsByType[sendedItem.type].RemoveAll(e => e.serialNumber == sendedItem.serialNumber);
                DataBase.updateDataBaseObjects("items", existItemsByType);
                return "ok";
            }
            return "";
        }
    }
}
            