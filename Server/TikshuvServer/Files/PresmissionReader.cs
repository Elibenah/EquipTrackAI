using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikshuvServer.Files;


namespace TikshuvServer
{
    internal class PremissionReader
    {
        public static Dictionary<string, int> requestPremissionDictionary = new Dictionary<string, int>();
        public static string path = "./Files/Setting.txt";
        public static void initSettingFile()
        {
            settingFile.CreateFile(path);

            //equipment related premission
            settingFile.WriteToFile(path, "addEquipment", "10");
            settingFile.WriteToFile(path, "getExistingEquipmentByType", "10");
            settingFile.WriteToFile(path, "getExistsEquipmentsList", "10");
            settingFile.WriteToFile(path, "addItemsToEquipment", "10");
            settingFile.WriteToFile(path, "updateEquipment", "10");

            //soliders related premission
            settingFile.WriteToFile(path, "getAllExistingSoliders", "10");
            settingFile.WriteToFile(path, "getPremission", "10");
            settingFile.WriteToFile(path, "updateSoliders", "10");
            settingFile.WriteToFile(path, "addSolider", "10");
            settingFile.WriteToFile(path, "soliderConnection", "10");

            //mission related premission
            settingFile.WriteToFile(path, "soliderConnection", "10");

        }
        public static void iterateOverPermissionFile()
        {
            
        }
    }
}
