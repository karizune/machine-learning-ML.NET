using System;
using System.Collections.Generic;
using Microsoft.ML;

namespace Machine_learning_csharpML.Model
{
    public class ConsumeModel
    {
        private static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

        public static ModelOutput Predict(ModelInput input)
        {
            ModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }

        public static List<ModelOutput> PredictFromList(List<ModelInput> inputs)
        {
            List<ModelOutput> results = new List<ModelOutput>();

            foreach (var input in inputs)
            {
                results.Add(PredictionEngine.Value.Predict(input));
            }

            return results;
        }

        public static void ShowResults(List<ModelOutput> outputs)
        {
            Console.WriteLine("The following results from the inputs is:\n");

            foreach (var output in outputs)
            {
                Console.WriteLine($"the wine is {output.Prediction}");
            }
        }

        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            MLContext mlContext = new MLContext();
            string modelPath = @"E:\luang\Desktop\Nova pasta (2)\machine-learning-ML.NET\Machine learning csharpML.Model\MLModel.zip";
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            return predEngine;
        }
    }
}
