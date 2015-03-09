//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;


class OddLines
{
    static void Main()
    {
        int counter = 1;

        using (StreamReader sr = new StreamReader(@"..\..\sample_text.txt"))
        {
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (counter%2 != 0)
                {
                    Console.WriteLine(line);    
                }
                counter++;
            }
        }
    }
}