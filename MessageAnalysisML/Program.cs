using Microsoft.ML;
using System;
using static MessageAnalysisML.MessageAnalysisMLModel;

namespace MessageAnalysisML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите 0, чтобы выйти");

            var inputStr = "";

            while (inputStr != "0")
            {
                inputStr = Console.ReadLine();
                var input = new ModelInput();
                input.Message = inputStr;

                var predictionResult = MessageAnalysisMLModel.Predict(input);

                Console.WriteLine(predictionResult.PredictedLabel == 1 ? "Это спам" : "Обычное сообщение");
                Console.WriteLine("---");
            }
        }
    }
}
