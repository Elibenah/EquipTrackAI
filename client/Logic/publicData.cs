using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.Logic
{
    internal class publicData
    {
        public static List<Equipment> existsEquipmentsList = new List<Equipment>();//Equipment
        public static Dictionary<string, List<Equipment>> existItemsByType = new Dictionary<string, List<Equipment>>();
        public static List<mission> missionsList = new List<mission>();
        public static List<missionInHistroy> historyMissions = new List<missionInHistroy>();
        public static List<Attachment> existingAttachments = new List<Attachment>();
        public static List<Solider> existingSoliders = new List<Solider>();
        public static List<Solider> existingResrvistsSoliders = new List<Solider>();// מילואים
        public static List<Solider> existingRegulatorySoliders = new List<Solider>();// אנשי קבע
        public static List<Solider> existingMandatorySoliders = new List<Solider>(); // אנשי סדיר
        public static List<Solider> existingOutsidersSoliders = new List<Solider>();// אנשי חוץ
        public static List<Signature> AllSignatureSummery = new List<Signature>();

    }
    public static class localCardential
    {
        public static string username = Environment.UserName;
        //public static IPAddress serverIp = IPAddress.Loopback;
        public static int portInServer = 9999;
        public static string ipServer = "127.0.0.1";
    }
}
