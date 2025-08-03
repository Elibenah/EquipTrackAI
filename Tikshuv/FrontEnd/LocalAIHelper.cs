using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Tikshuv.FrontEnd
{
    // --- ML.NET Data Model Classes ---
    public class ModelInput
    {
        [LoadColumn(0)]
        public string Text { get; set; } = "";

        [LoadColumn(1)]
        public string Label { get; set; } = "";
    }

    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabel { get; set; } = "";
    }


    // Provides AI-powered assistance using a local ML.NET model.

    public class LocalAIHelper
    {
        private readonly PredictionEngine<ModelInput, ModelOutput> _predictionEngine;

        public LocalAIHelper()
        {
            try
            {
                var mlContext = new MLContext();
                string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HebrewClassifier.zip");

                if (!File.Exists(modelPath))
                {
                    throw new FileNotFoundException($"Model file not found at {modelPath}. Ensure the model is set to 'Copy to Output Directory'.");
                }

                ITransformer loadedModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
                _predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(loadedModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load the AI model. Error: {ex.Message}", "Model Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private string GetPredictedFormName(string userText)
        {
            var sampleInput = new ModelInput { Text = userText };
            var result = _predictionEngine.Predict(sampleInput);
            return result.PredictedLabel;
        }


        // Handles a user request by querying the local model and loading the appropriate form.

        public void HandleUserRequest(string userText, Form currentForm)
        {
            try
            {
                //  Get prediction from the local model
                string resultFormName = GetPredictedFormName(userText);

                if (string.IsNullOrWhiteSpace(resultFormName))
                {
                    throw new InvalidOperationException("The model returned an empty prediction.");
                }

                if (resultFormName.Equals("Main", StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException("Navigation to the 'Main' form is not a valid action.");
                }

                //  Find the Form type using reflection
                // This now searches ALL loaded assemblies in the application, not just the main one.
                Type? formType = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .FirstOrDefault(t => t.Name.Equals(resultFormName, StringComparison.OrdinalIgnoreCase) && typeof(Form).IsAssignableFrom(t));


                if (formType == null)
                {
                    throw new InvalidOperationException($"Could not find Form type for '{resultFormName}' in the assembly.");
                }

                //Create an instance of the Form and display it
                var form = (Form)Activator.CreateInstance(formType)!;

                if (currentForm.Controls["panelChildForm"] is Panel panel)
                {
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;

                    panel.Controls.Clear();
                    panel.Controls.Add(form);
                    form.Show();
                }
                else
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("לא הצלחתי להבין את הבקשה או שלא נמצא עמוד מתאים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
