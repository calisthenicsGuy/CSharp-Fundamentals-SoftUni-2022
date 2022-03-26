using System;
using System.Linq;

namespace P03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            //string fileInfo = file.Substring(file.LastIndexOf('\\')+1);
            //int dotIndex = fileInfo.LastIndexOf('.');

            //string fileName = fileInfo.Substring(0, dotIndex);
            //string fileExtension = fileInfo.Substring(dotIndex+1);

            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExtension}");


            // Array solution
            string[] fileInfo = file
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Split('.', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string fileName = String.Join('.', fileInfo.Take(fileInfo.Length-1));
            string fileExtension = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
