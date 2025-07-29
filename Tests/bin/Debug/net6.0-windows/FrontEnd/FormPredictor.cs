using Microsoft.ML;

namespace Tikshuv.FrontEnd
{
    public class FormInput
    {
        public string Text { get; set; }
        public string Label { get; set; }
    }

    public class FormPrediction
    {
        public string PredictedForm { get; set; }
    }

    public class FormPredictor
    {
        private readonly PredictionEngine<FormInput, FormPrediction> _predictionEngine;

        public FormPredictor()
        {
            var mlContext = new MLContext();
            var modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FormClassifier.zip");

            ITransformer model = mlContext.Model.Load(modelPath, out var _);
            _predictionEngine = mlContext.Model.CreatePredictionEngine<FormInput, FormPrediction>(model);
        }

        public string PredictForm(string userText)
        {
            var input = new FormInput { Text = userText };
            var prediction = _predictionEngine.Predict(input);
            return prediction.PredictedForm;
        }
    }
}
