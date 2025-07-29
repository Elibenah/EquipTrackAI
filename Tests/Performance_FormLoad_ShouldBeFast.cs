using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.Logic.DataAccsess;
using Xunit;
using System.Collections.Generic;

namespace Tikshuv.SignatureTests
{
    public class SignatureFormPerformanceTests
    {
        [Fact]
        public void Performance_SignatureForm_ShouldLoadUnder100ms()
        {
            // Arrange: create a test mission object
            var testMission = new mission
            {
                missionId = "loadtest001",
                missionName = "Performance Load Test",
                itemsInMissions = new Dictionary<string, List<EquipmentInMission>>
                {
                    {
                        "SampleItem", new List<EquipmentInMission>
                        {
                            new EquipmentInMission
                            {
                                serialNumber = "0001",
                                attachmentOfEquiment = new List<Attachment>
                                {
                                    new Attachment { name = "Battery", inMission = true }
                                }
                            }
                        }
                    }
                }
            };

            var times = new long[5];

            // Act: measure 5 load durations
            for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                var form = new SignatureForm(testMission);
                form.Show();
                form.Close();
                form.Dispose();

                sw.Stop();
                times[i] = sw.ElapsedMilliseconds;
            }

            double avg = times.Average();

            // Assert: check average is within 100ms
            Assert.InRange(avg, 0, 100);
        }
    }
}
