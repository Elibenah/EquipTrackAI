using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikshuvServer.equipmentManagment;

namespace TikshuvServer
{
    public class missionInHistroy : missionObject
    {
        public string timeAdded { get; set; }
        public string timeUpdated { get; set; }
        public string updatedBy { get; set; }
    }

    internal class missionRequestHandling
    {
        public static string historyMissionListDataBase;
        public static string missionsListDataBase;

        public static missionInHistroy currentMissionToAddToHistory;

        public static List<missionObject> missionsList = new List<missionObject>();//Mission list
        public static List<missionInHistroy> historyMissions = new List<missionInHistroy>();// history of missions and items in them
        public static void initMissionToMemory()
        {
            historyMissionListDataBase = DataBase.DataFromSave("session", "historyMissions").ToString();
            missionsListDataBase = DataBase.DataFromSave("session", "missionsList").ToString();

            if (missionsListDataBase != "")
            {
                missionsList = JsonConvert.DeserializeObject<List<missionObject>>(missionsListDataBase.ToString());
            }
            if (historyMissionListDataBase != "")
            {
                //historyMissions = historyMissionListDataBase.ToObject<List<missionObject>>();
                historyMissions = JsonConvert.DeserializeObject<List<missionInHistroy>>(historyMissionListDataBase.ToString());
            }
        }

        public static object[] equipmentRequestFromClient(requestObject request)
        {
            object[] array = new object[2];
            //array[0] - data
            //array[1] - if authorized
            //array[2] - if to send to every client
            bool ifAccepted = false;
            switch (request.request)
            {
                case "getAllMissions":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = missionsList;
                    array[1] = true;
                    return array;
                case "addMission":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = "";
                    array[1] = addNewMission(request);
                    Server.broadcastUpdate(request.requestSubject, "getAllMissions", missionsList);
                    break;
                case "getAllHistoryMission":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = historyMissions;
                    array[1] = true;
                    return array;
                case "updateMission":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = updateMission(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getAllMissions", missionsList);
                    return array;
                case "updateHistoryMission":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    //array[0] = historyMissions;
                    array[1] = true;
                    //Server.broadcastUpdate(historyMissions);
                    return array;
                case "removeMission":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = removeMission(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getAllMissions", missionsList);
                    return array;

                case "removeItems":
                    ifAccepted = soliderRequestHandling.checkPremission(request.ID, 10);
                    if (!ifAccepted)
                    {
                        array[0] = "";
                        array[1] = false;
                        return array;
                    }
                    array[0] = removeItems(request);
                    array[1] = true;
                    Server.broadcastUpdate(request.requestSubject, "getAllMissions", missionsList);
                    Server.broadcastUpdate(request.requestSubject, "getAllHistoryMission", historyMissions);
                    return array;

                default:
                    break;
            }

            return array;
        }
        public static bool checkExisted(missionObject mission)
        {
            for (int i = 0; i < missionsList.Count; i++)
            {
                if (missionsList[i].missionId == mission.missionId)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool updateMission(requestObject request)
        {
            missionObject addedMission = new missionObject();
            addedMission = JObject.Parse(request.data.ToString()).ToObject<missionObject>();

            for (int i = 0; i < missionsList.Count; i++)
            {
                if (missionsList[i].missionId == addedMission.missionId)
                {
                    missionsList[i] = addedMission;
                }
            }
            DataBase.updateDataBaseObjects("missionsList", missionsList);
            return true;
        }
        public static bool addNewMission(requestObject request)
        {
            missionObject addedMission = new missionObject();
            addedMission = JObject.Parse(request.data.ToString()).ToObject<missionObject>();

            if(!checkExisted(addedMission))
            {
                missionsList.Add(addedMission);
                DataBase.updateDataBaseObjects("missionsList", missionsList);
                EquipmentManagmentMethods.updateEquipmentPlacmentByMission(addedMission);
                return true;
            }
            else
            {
                for (int i = 0; i < missionsList.Count; i++)
                {
                    if (missionsList[i].missionId == addedMission.missionId)
                    {
                        missionsList[i] = addedMission;
                    }
                }

                DataBase.updateDataBaseObjects("missionsList", missionsList);
                EquipmentManagmentMethods.updateEquipmentPlacmentByMission(addedMission);

                return true;
            }
        }
        public static bool removeMission(requestObject request)
        {
            missionObject removedMission = new missionObject();
            removedMission = JObject.Parse(request.data.ToString()).ToObject<missionObject>();

            for (int i = 0; i < missionsList.Count; i++)
            {
                if (missionsList[i].missionId == removedMission.missionId)
                {
                    missionsList.RemoveAt(i);
                }
            }
            DataBase.updateDataBaseObjects("missionsList", missionsList);
            return true;
        }
        public static bool removeItems(requestObject request)
        {
            try
            {
                missionObject missionToRemoveItemFrom = new missionObject();
                missionToRemoveItemFrom = JObject.Parse(request.data.ToString()).ToObject<missionObject>();

                missionObject pointedMission = new missionObject();

                foreach(missionObject mission in missionsList)
                {
                    if(mission.missionId == missionToRemoveItemFrom.missionId)
                    {
                        pointedMission = mission;
                        break;
                    }
                }

                foreach (var kvp in missionToRemoveItemFrom.itemsInMissions)
                {
                    var itemToRemove = missionToRemoveItemFrom.itemsInMissions[kvp.Key].Cast<EquipmentInMission>()
                    .FirstOrDefault(c => c.serialNumber == kvp.Value.First().serialNumber);
                    if (pointedMission.itemsInMissions.ContainsKey(kvp.Key))
                    {
                        pointedMission.itemsInMissions[kvp.Key].RemoveAll(val => val.serialNumber == itemToRemove.serialNumber);
                        if(pointedMission.itemsInMissions[kvp.Key].Count == 0)
                        {
                            pointedMission.itemsInMissions.Remove(kvp.Key);
                        }
         
                    }

                    //existsItemByType change
                    foreach (var equipment in equipmentRequestHandling.existItemsByType[kvp.Key])
                    {
                        if(equipment.serialNumber ==  itemToRemove.serialNumber)
                        {
                            equipment.currentMissionName = null;
                            if (missionToRemoveItemFrom.isFixedMission == false)
                            {
                                equipment.tempMissionName = null;
                                if (equipment.fixedMissionName != null)
                                {
                                    equipment.currentMissionName = equipment.fixedMissionName;
                                }
                            }
                            if (missionToRemoveItemFrom.isFixedMission == true)
                            {
                                equipment.fixedMissionName = null;
                            }
                            if (itemToRemove.attachmentOfEquiment != null)
                            {
                                if (itemToRemove.attachmentOfEquiment.Count > 0)
                                {
                                    foreach (var attachment in itemToRemove.attachmentOfEquiment)
                                    {
                                        var attachmentOnExistItemsByType = equipment.Addons.Find(c => c.name == attachment.name);
                                        if (attachment.isCredited == true)
                                        {
                                            attachmentOnExistItemsByType.inMission = false;
                                            attachmentOnExistItemsByType.isCredited = false;
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                }

                //creating history
                bool missionExistsInHistory = false;
                for (int j = 0; j < historyMissions.Count; j++)
                {
                    if (pointedMission.missionId == historyMissions[j].missionId)
                    {
                        missionExistsInHistory = true;
                        currentMissionToAddToHistory = historyMissions[j];
                        break;
                    }
                }
                if (!missionExistsInHistory)
                {
                    currentMissionToAddToHistory = new missionInHistroy();
                    currentMissionToAddToHistory.itemsInMissions = new Dictionary<string, List<EquipmentInMission>> { };
                    currentMissionToAddToHistory.missionId = pointedMission.missionId;
                    currentMissionToAddToHistory.missionName = pointedMission.missionName + " : " + DateTime.Now;
                    currentMissionToAddToHistory.timeAdded = DateTime.Now.ToString();
                    historyMissions.Add(currentMissionToAddToHistory);
                }
                foreach(var kvp in missionToRemoveItemFrom.itemsInMissions)
                {
                    currentMissionToAddToHistory.timeUpdated = DateTime.Now.ToString();
                    if (currentMissionToAddToHistory.itemsInMissions.ContainsKey(kvp.Key))
                    {
                        foreach(EquipmentInMission iterator in kvp.Value)
                        {
                            currentMissionToAddToHistory.itemsInMissions[kvp.Key].Add(new EquipmentInMission() { serialNumber = iterator.serialNumber + " : " + DateTime.Now.ToString() });
                        }
                    }
                    else
                    {
                        currentMissionToAddToHistory.itemsInMissions.Add(kvp.Key, new List<EquipmentInMission>());
                        foreach (EquipmentInMission iterator in kvp.Value)
                        {
                            currentMissionToAddToHistory.itemsInMissions[kvp.Key].Add(new EquipmentInMission() { serialNumber = iterator.serialNumber + " : " + DateTime.Now.ToString() });
                        }
                    }
                }
                for (int j = 0; j < historyMissions.Count; j++)
                {
                    if (pointedMission.missionId == historyMissions[j].missionId)
                    {
                        historyMissions[j] = currentMissionToAddToHistory;
                        break;
                    }
                }
                if(pointedMission.itemsInMissions.Count > 0)
                {
                    for (int j = 0; j < missionRequestHandling.missionsList.Count; j++)
                    {
                        if (missionsList[j].missionId == pointedMission.missionId)
                        {
                            missionsList[j] = pointedMission;
                            break;
                        }
                    }
                }
                else
                {
                    missionsList.RemoveAll(m => m.missionId == pointedMission.missionId);
                }
                

                DataBase.updateDataBaseObjects("historyMissions", historyMissions);
                DataBase.updateDataBaseObjects("items", equipmentRequestHandling.existItemsByType);
                DataBase.updateDataBaseObjects("equipment", equipmentRequestHandling.existsEquipmentsList);
                DataBase.updateDataBaseObjects("missionsList", missionsList);
                
                return true;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static void UnsignedMissionBySignature(string missionId)
        {
            var mission = missionsList.FirstOrDefault(m => m.missionId == missionId);
            if (mission != null)
            {
                mission.isSigned = false;
            }
            DataBase.updateDataBaseObjects("missionsList", missionsList);
        }
        public static void SignMissionBySignature(string missionId)
        {
            var mission = missionsList.FirstOrDefault(m => m.missionId == missionId);
            if (mission != null)
            {
                mission.isSigned = true;
            }
            DataBase.updateDataBaseObjects("missionsList", missionsList);
        }
    }
}
