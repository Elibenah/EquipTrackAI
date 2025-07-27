using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.Logic.Handlers
{
    internal class SignatureResponse
    {
        
        public static object SignatureResponseHandler(responseObject responseFromServer)
        {
            string jsonData = responseFromServer.data?.ToString() ?? "";

            switch (responseFromServer.request)
            {
                case "GetMissionSummaries":
                    if (responseFromServer.data != null && jsonData != "[]")
                    {
                        var parsed = JArray.Parse(jsonData)
                            .ToObject<List<Signature>>();

                        if (parsed != null)
                        {
                            publicData.AllSignatureSummery = parsed;
                        }
                        else
                        {
                            MessageBox.Show("Failed to load signature", "Error");
                        }
                    }
                    break;
                case "GetSignature":
                    if (responseFromServer.data != null && jsonData != "[]")
                    {
                        var parsed = JObject.Parse(jsonData)
                            .ToObject<Signature>();

                        if (parsed != null)
                        {
                            Signature test = parsed;
                            return parsed;
                        }
                        else
                        {
                            MessageBox.Show("Failed to load signature", "Error");
                        }
                    }
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
