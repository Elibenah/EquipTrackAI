using System;
using System.Drawing;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.Logic.DataAccsess;
using Xunit;
using System.Collections.Generic;

namespace Tikshuv.SignatureTests
{
    public class SignatureFormTests
    {
        [Fact]
        public void SignaturePanel_ShouldProduce_ByteArray_LargerThan1KB()
        {
            // Arrange: Create a fake mission to pass into the form
            var testMission = new mission
            {
                missionId = "test123",
                missionName = "Signature Test",
                itemsInMissions = new Dictionary<string, List<EquipmentInMission>>
                {
                    {
                        "Test Item", new List<EquipmentInMission>
                        {
                            new EquipmentInMission
                            {
                                serialNumber = "12345",
                                attachmentOfEquiment = new List<Attachment>
                                {
                                    new Attachment { name = "Scope", inMission = true }
                                }
                            }
                        }
                    }
                }
            };

            // Initialize the form with the fake mission
            var form = new SignatureForm(testMission);
            form.Show(); // Needed to initialize the panel for drawing

            // Simulate drawing on the signature panel
            using (Graphics g = form.signaturePanel.CreateGraphics())
            {
                g.FillRectangle(Brushes.Black, 10, 10, 200, 80);
            }

            // Act: Get the signature as byte array
            byte[] signatureBytes = form.GetSignatureBytes();

            // Assert: Check that signature size is larger than 1KB
            Assert.True(signatureBytes.Length >= 1024, $"Signature is too small: {signatureBytes.Length} bytes");
        }
    }
}
