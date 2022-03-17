using System;
using Machine_learning_csharp;
using Machine_learning_csharpML;
using Machine_learning_csharpML.Model;

namespace Machine_learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var sampleData = new ModelInput
            {
                Fixed_acidity = 7.4F,
                Volatile_acidity = 0.7F,
                Citric_acid = 0F,
                Residual_sugar = 1.9F,
                Chlorides = 0.076F,
                Total_sulfur_dioxide = 34,
                Density = 0.9978F,
                PH = 3.51F,
                Sulphates = 0.56F,
                Alcohol = "9.4",
                Quality = 5F
            };

            var result = ConsumeModel.Predict(sampleData);

            Console.WriteLine($"the wine is {result.Prediction}");
        }
    }
}
