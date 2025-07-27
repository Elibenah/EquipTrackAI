using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.Logic.Handlers
{
    internal class missionResponse
    {
        public static void missionResponseHandler(responseObject responseFromServer) 
        {
            string jsonData = responseFromServer.data.ToString();
            switch(responseFromServer.request)
            {
                case "getAllMissions":
                    if (responseFromServer.data != null)
                    {
                        string type = responseFromServer.data.GetType().ToString();

                        Logic.publicData.missionsList = JArray.Parse(jsonData).ToObject<List<mission>>();
                    }
                        break;
                case "addMission":
                    break;
                case "getAllHistoryMission":
                    if (responseFromServer.data != null)
                    {
                        string type = responseFromServer.data.GetType().ToString();

                        Logic.publicData.historyMissions = JArray.Parse(jsonData).ToObject<List<missionInHistroy>>();
                    }
                    break;
                case "updateMission":
                    break;
                default:
                    break;
            }
        }
    }
}
