using System;
using System.IO;

namespace ReadingFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\elise\Downloads\Pride and Prejudice by Jane Austen.txt";

            string[] allLines = File.ReadAllLines(filePath);
            string entireBook = File.ReadAllText(filePath);

            //output 5 lines of the book at a time
            //ctrl + k + c to comment multiple lines at a time and ctrl + k + u to uncomment
            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines[i]);
            //}

            //output a chapter at a time
            foreach (var line in allLines)
            {
                if (line.Contains("Chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }


            //Console.WriteLine(entireBook);
            //Console.WriteLine(allLines);

        }
    }
}
