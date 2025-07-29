using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.Logic.DataAccsess;
using Xunit;

namespace Tikshuv.SignatureTests
{
    public class LoadTests
    {
        [Fact]
        public void LoadTest_SignatureForm_Concurrency()
        {
            const int userCount = 50;
            var tasks = new List<Task>();
            long initialMemory = GC.GetTotalMemory(true);

            // Act
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < userCount; i++)
            {
                tasks.Add(Task.Run(() =>
                {
                    var testMission = new mission
                    {
                        missionId = Guid.NewGuid().ToString(),
                        missionName = "Load Test",
                        itemsInMissions = new Dictionary<string, List<EquipmentInMission>>
                        {
                            {
                                "Item", new List<EquipmentInMission>
                                {
                                    new EquipmentInMission
                                    {
                                        serialNumber = "X" + Guid.NewGuid().ToString("N"),
                                        attachmentOfEquiment = new List<Attachment>
                                        {
                                            new Attachment { name = "Battery", inMission = true }
                                        }
                                    }
                                }
                            }
                        }
                    };

                    var form = new SignatureForm(testMission);
                    form.Show();
                    form.Close();
                    form.Dispose();
                }));
            }

            Task.WaitAll(tasks.ToArray());

            sw.Stop();
            long finalMemory = GC.GetTotalMemory(true);
            long usedMemory = finalMemory - initialMemory;
            double memoryPerUserMB = usedMemory / 1024.0 / 1024.0 / userCount;

            // Log output
            Console.WriteLine($"✅ Load test complete.");
            Console.WriteLine($"🧠 Average memory per form: {memoryPerUserMB:F2} MB");
            Console.WriteLine($"⏱ Total time: {sw.ElapsedMilliseconds} ms");

            // Assert: expected under 200MB per instance and reasonable runtime
            Assert.InRange(memoryPerUserMB, 0, 200);
        }
    }
}
