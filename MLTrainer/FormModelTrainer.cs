// Using directives for necessary libraries
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;

// You can use a console application for this or a simple class library.
// For this example, let's assume it's in a class that handles model logic.
namespace Tikshuv.ML
{
    // --- Data Model Classes ---
    // These classes define the structure of input and output data.


    // Represents a single row of input data from CSV file
    public class ModelInput
    {
        // Attribute to specify loading from the first column (index 0) of the CSV.
        [LoadColumn(0)]
        public string Text { get; set; } = string.Empty;

        // Attribute to specify loading from the second column (index 1) of the CSV.
        [LoadColumn(1)]
        public string Label { get; set; } = string.Empty;
    }


    // Represents the output of the model's prediction.
    public class ModelOutput
    {
        // Attribute to map this property to the "PredictedLabel" column produced by the pipeline.
        [ColumnName("PredictedLabel")]
        public string PredictedLabel { get; set; } = string.Empty;
    }

    // --- Model Training Class ---
    // This class encapsulates all the logic for training, saving, and using the model.
    public static class ModelTrainer
    {
        // Define file paths as constants for easy management.
        // Using an absolute path to work around the build issue.
        private static readonly string DataPath = @"D:\FP\MLTrainer\ML_Data\training_data.csv";
        private static readonly string ModelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ML_Model", "HebrewClassifier.zip");


        // Main method to orchestrate the model training, evaluation, and saving process.
        public static void TrainAndSaveModel()
        {
            // Initialize the ML.NET environment
            var mlContext = new MLContext(seed: 0);
            Console.WriteLine("--- Starting Model Training & Evaluation ---");

            // --- Data Loading ---
            if (!File.Exists(DataPath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: Training data file not found at: {DataPath}");
                Console.ResetColor();
                return;
            }

            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                path: DataPath,
                hasHeader: false,
                separatorChar: ','
            );

            //  Split the data into training and testing sets (80% for training, 20% for testing)
            var trainTestSplit = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2, seed: 0);
            var trainingData = trainTestSplit.TrainSet;
            var testData = trainTestSplit.TestSet;

            // Define the training pipeline
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: "Label", outputColumnName: "LabelKey")
                .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName: "Text", outputColumnName: "Features"))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(labelColumnName: "LabelKey", featureColumnName: "Features"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            // Train the model ONLY on the training data
            Console.WriteLine("Training the model...");
            var model = pipeline.Fit(trainingData);
            Console.WriteLine("Model trained successfully!");

            // Evaluate the model on the unseen test data
            Console.WriteLine("Evaluating model performance on test data...");
            var predictions = model.Transform(testData);
            var metrics = mlContext.MulticlassClassification.Evaluate(predictions, labelColumnName: "LabelKey");

            //  Display the evaluation metrics
            Console.WriteLine("\n==================================================");
            Console.WriteLine("         Model Evaluation Metrics");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"  MicroAccuracy:    {metrics.MicroAccuracy:P2}");
            Console.WriteLine($"  MacroAccuracy:    {metrics.MacroAccuracy:P2}");
            Console.WriteLine($"  Log-loss:         {metrics.LogLoss:F4}");
            Console.WriteLine("==================================================\n");

            // --- Model Saving ---
            var modelDirectory = Path.GetDirectoryName(ModelPath);
            if (modelDirectory != null)
            {
                Directory.CreateDirectory(modelDirectory);
            }
            mlContext.Model.Save(model, dataView.Schema, ModelPath);
            Console.WriteLine($"Model saved to: {ModelPath}");
            Console.WriteLine("--- Process Complete ---");
        }


        //Example method to demonstrate how to use the trained model for prediction.
        public static void PredictSample()
        {
            // Initialize the ML.NET environment.
            var mlContext = new MLContext();

            // --- Load the Model ---
            // Load the model from the .zip file.
            ITransformer loadedModel = mlContext.Model.Load(ModelPath, out var modelInputSchema);

            // --- Create Prediction Engine ---
            var predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(loadedModel);

            // --- Make a Prediction ---
            var sampleInput = new ModelInput { Text = "נתוני חיילים" };
            var result = predictionEngine.Predict(sampleInput);

            // Display the result.
            Console.WriteLine("\n--- Prediction Example ---");
            Console.WriteLine($"Input Text: {sampleInput.Text}");
            Console.WriteLine($"Predicted Command: {result.PredictedLabel}");
            Console.WriteLine("--------------------------");
        }
    }
}
