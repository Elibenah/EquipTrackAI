using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikshuvServer.equipmentManagment
{
    public class EquipmentManagmentMethods
    {
        public static void updateEquipmentPlacmentByMission(missionObject mission)
        {
            foreach(KeyValuePair<string, List<EquipmentInMission>> typeEquipment in mission.itemsInMissions)
            {
                foreach(EquipmentInMission itemSerial in typeEquipment.Value)
                {
                    for(int i = 0; i < equipmentRequestHandling.existItemsByType[typeEquipment.Key].Count;i++)
                    {
                        if(equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].serialNumber == itemSerial.serialNumber && itemSerial.serialNumber.ToLower() != "n\\a")
                        {
                            equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].currentMissionName = mission.missionName;
                            equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].lastChange = DateTime.Now;
                            if (mission.isFixedMission)
                            {
                                equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].fixedMissionName = mission.missionName;
                            }
                            else
                            {
                                equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].tempMissionName = mission.missionName;
                            }
                            if(itemSerial.attachmentOfEquiment != null && itemSerial.attachmentOfEquiment.Count > 0)
                            {
                                foreach (var item in itemSerial.attachmentOfEquiment)
                                {
                                    if (equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].Addons.Contains(item))
                                    {
                                        equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].Addons.Find(item1 => item1.name == item.name).inMission = true;
                                    }
                                }
                            }
                            
                            //foreach (var item in list_2)
                            //{
                            //    if (list_1.Contains(item))
                            //    {
                            //        list_1.Find(item1 => item1.Id == item.Id).Name = "deeznoots";
                            //    }
                            //}
                            //equipmentRequestHandling.existItemsByType[typeEquipment.Key][i].Addons = itemSerial.attachmentOfEquiment;

                        }
                    }
                }
            }
            DataBase.updateDataBaseObjects("items", equipmentRequestHandling.existItemsByType);
        }
    }
}
