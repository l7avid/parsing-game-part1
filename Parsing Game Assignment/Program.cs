using System.IO;

namespace Parsing_Game_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\21 - Parse Game Assignment\input.txt";
            string outputFilePath = @"C:\Users\david.reina\Documents\Personal Devs\Ruta N Udemy - C#\21 - Parse Game Assignment\output.txt";
            string[] fileText = File.ReadAllLines(inputFilePath);
            List<string> hiddenText = new List<string>();

            foreach(string line in fileText)
            {
                if(line.Contains("split"))
                {
                    hiddenText.Add(line.Split()[4]);
                }
            }

            File.WriteAllLines(outputFilePath, hiddenText);
        }
    }
}