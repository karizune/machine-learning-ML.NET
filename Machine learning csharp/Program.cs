using System;
using System.Collections.Generic;
using Machine_learning_csharpML.Model;

namespace Machine_learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 entradas
            var sampleData = new List<ModelInput>() { 
                new ModelInput()
                {
                    Fixed_acidity = 7.4F,
                    Volatile_acidity = 0.7F,
                    Citric_acid = 0F,
                    Residual_sugar = 1.9F,
                    Chlorides = 0.076F,
                    Free_sulfur_dioxide = 11,
                    Total_sulfur_dioxide = 34F,
                    Density = 0.9978F,
                    PH = 3.51F,
                    Sulphates = 0.56F,
                    Alcohol = @"9.4",
                    Quality = 5F
                },
                new ModelInput()
                {
                    Fixed_acidity = 7F,
                    Volatile_acidity = 0.27F,
                    Citric_acid = 0.36F,
                    Residual_sugar = 20.7F,
                    Chlorides = 0.045F,
                    Free_sulfur_dioxide = 45,
                    Total_sulfur_dioxide = 170F,
                    Density = 1.001F,
                    PH = 3F,
                    Sulphates = 0.45F,
                    Alcohol = @"8.8",
                    Quality = 6F
                },
                new ModelInput()
                {
                    Fixed_acidity = 8.3F,
                    Volatile_acidity = 0.42F,
                    Citric_acid = 0.62F,
                    Residual_sugar = 19.25F,
                    Chlorides = 0.04F,
                    Free_sulfur_dioxide = 41,
                    Total_sulfur_dioxide = 172,
                    Density = 10.002F,
                    PH = 2.98F,
                    Sulphates = 0.67F,
                    Alcohol = @"9.7",
                    Quality = 5F
                },
                new ModelInput()
                {
                    Fixed_acidity = 7.4F,
                    Volatile_acidity = 0.34F,
                    Citric_acid = 0.42F,
                    Residual_sugar = 1.1F,
                    Chlorides = 0.033F,
                    Total_sulfur_dioxide = 17,
                    Density = 0.9917F,
                    PH = 3.12F,
                    Sulphates = 0.53F,
                    Alcohol = @"11.3",
                    Quality = 6F
                },
                new ModelInput()
                {
                    Fixed_acidity = 5.6F,
                    Volatile_acidity = 0.615F,
                    Citric_acid = 0F,
                    Residual_sugar = 1.6F,
                    Chlorides = 0.089F,
                    Free_sulfur_dioxide = 16,
                    Total_sulfur_dioxide = 59,
                    Density = 0.9943F,
                    PH = 3.58F,
                    Sulphates = 0.52F,
                    Alcohol = @"9.9",
                    Quality = 5F
                },
            };

            var results = ConsumeModel.PredictFromList(sampleData);
            ConsumeModel.ShowResults(results);
            Console.ReadKey();
        }
    }
}
