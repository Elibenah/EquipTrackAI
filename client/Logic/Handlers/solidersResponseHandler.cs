using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.Logic.Handlers
{
    internal class solidersResponse
    {
        public static void solidersResponseHandler(responseObject responseFromServer)
        {
            string jsonData = responseFromServer.data?.ToString() ?? "";
            switch (responseFromServer.request)
            {
                case "getAllExistingSoliders":
                    if (responseFromServer.data != null)
                    {
                        var parsed = JArray.Parse(jsonData).ToObject<List<Solider>>();

                        if (parsed != null)
                        {
                            Logic.publicData.existingSoliders = parsed;

                            // Clear all categorized lists before re-updating
                            publicData.existingResrvistsSoliders.Clear();
                            publicData.existingRegulatorySoliders.Clear();
                            publicData.existingMandatorySoliders.Clear();
                            publicData.existingOutsidersSoliders.Clear();
                            if (publicData.existingSoliders.Count > 0)
                            {
                                publicData.existingResrvistsSoliders = publicData.existingSoliders.Where(s => s.premissionLevel == 0).ToList();
                                publicData.existingRegulatorySoliders = publicData.existingSoliders.Where(s => s.premissionLevel == 1).ToList();
                                publicData.existingMandatorySoliders = publicData.existingSoliders.Where(s => s.premissionLevel == 2).ToList();
                                publicData.existingOutsidersSoliders = publicData.existingSoliders.Where(s => s.premissionLevel == 3).ToList();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load soliders by type", "Error");
                        }
                    }
                        break;

                default:
                    break;
            }
        }
    }
}
