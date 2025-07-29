using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tikshuv.FrontEnd;
using Tikshuv.Logic.DataAccsess;
using Xunit;
using System.Collections.Generic;

namespace Tikshuv.SignatureTests
{
    public class SignatureFormValidSignatureTests
    {
        [Fact]
        public void Signature_ShouldBeAccepted_WhenValid()
        {
            // Arrange: create mock mission
            var testMission = new mission
            {
                missionId = "m001",
                missionName = "Test Mission",
                itemsInMissions = new Dictionary<string, List<EquipmentInMission>>
                {
                    {
                        "TestItem", new List<EquipmentInMission>
                        {
                            new EquipmentInMission
                            {
                                serialNumber = "12345",
                                attachmentOfEquiment = new List<Attachment>
                                {
                                    new Attachment { name = "Camera", inMission = true }
                                }
                            }
                        }
                    }
                }
            };

            var form = new SignatureForm(testMission);
            form.Show();

            // Create a fake heavy signature bitmap
            Bitmap fakeSignature = new Bitmap(form.signaturePanel.Width, form.signaturePanel.Height);
            using (Graphics g = Graphics.FromImage(fakeSignature))
            {
                g.Clear(Color.White);

                // Draw large solid ellipse to ensure size > 1KB
                g.FillEllipse(Brushes.Black, 0, 0, form.signaturePanel.Width, form.signaturePanel.Height);
            }

            // Set the bitmap as background of the panel (visible for DrawToBitmap)
            form.signaturePanel.BackgroundImage = fakeSignature;
            form.signaturePanel.BackgroundImageLayout = ImageLayout.None;

            // Act
            byte[] signatureBytes = form.GetSignatureBytes();
            string base64Signature = Convert.ToBase64String(signatureBytes);

            // Assert
            Assert.NotNull(signatureBytes);
            Assert.True(signatureBytes.Length >= 1024, $"Signature too small: {signatureBytes.Length} bytes");
            Assert.False(string.IsNullOrWhiteSpace(base64Signature), "Base64 conversion failed");
        }
    }
}
