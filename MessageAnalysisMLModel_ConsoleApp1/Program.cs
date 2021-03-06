
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MessageAnalysisMLModel_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MessageAnalysisMLModel.ModelInput sampleData = new MessageAnalysisMLModel.ModelInput()
            {
                Message = @"Ok lar... Joking wif u oni...",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MessageAnalysisMLModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Spam with predicted Spam from sample data...\n\n");


            Console.WriteLine($"Spam: {0F}");
            Console.WriteLine($"Message: {@"Ok lar... Joking wif u oni..."}");


            Console.WriteLine($"\n\nPredicted Spam: {predictionResult.PredictedLabel}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
