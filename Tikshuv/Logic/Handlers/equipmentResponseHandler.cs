using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tikshuv.FrontEnd.StorageWindow.StorageManager;
using Tikshuv.Logic.DataAccsess;

namespace Tikshuv.Logic.Handlers
{
    internal class equipmentResponse
    {
        public static void equipmentResponseHandler(responseObject responseFromServer)
        {
            string jsonData = responseFromServer.data?.ToString() ?? "";

            switch (responseFromServer.request)
            {
           
                case "getExistingEquipmentByType":
                    if (responseFromServer.data != null && jsonData != "[]")
                    {
                        var parsed = JObject.Parse(jsonData)
                            .ToObject<Dictionary<string, List<Equipment>>>();

                        if (parsed != null)
                        {
                            Logic.publicData.existItemsByType = parsed;
                            FrontEnd.Missions.updateAvailableEquipment();
                        }
                        else
                        {
                            MessageBox.Show("Failed to load equipment by type", "Error");
                        }
                    }
                    break;

                case "getExistsEquipmentsList":
                    if (responseFromServer.data != null)
                    {
                        var parsed = JArray.Parse(jsonData)
                            .ToObject<List<Equipment>>();

                        if (parsed != null)
                        {
                            Logic.publicData.existsEquipmentsList = parsed;
                        }
                        else
                        {
                            MessageBox.Show("Failed to load equipment list", "Error");
                        }
                    }
                    break;

                case "getExistsAttachmentList":
                    if (responseFromServer.data != null)
                    {
                        var parsed = JArray.Parse(jsonData)
                            .ToObject<List<Attachment>>();

                        if (parsed != null)
                        {
                            Logic.publicData.existingAttachments = parsed;

                            // Try to refresh the list in AddAttachments window if it's open
                            var openForm = Application.OpenForms
                                .OfType<AddAttachments>()
                                .FirstOrDefault();

                            if (openForm != null)
                            {
                                openForm.Invoke((MethodInvoker)(() =>
                                    openForm.LoadAttachments()));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to load attachments", "Error");
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
