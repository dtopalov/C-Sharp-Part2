//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

class SortedNames
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\input.txt");
        List<string> input = new List<string>();

        while (true)
        {
            string line = sr.ReadLine();
            if (line == null)
            {
                break;
            }
            input.AddRange(line.Trim().Split(new []{' ', ',','.'}, StringSplitOptions.RemoveEmptyEntries));
        }
        sr.Close();
        input.Sort();

        using (StreamWriter sw = new StreamWriter(@"..\..\output.txt"))
        {
            for (int i = 0; i < input.Count; i++)
            {
                sw.WriteLine(input[i]);
            }
        }

        using (StreamReader readingResult = new StreamReader(@"..\..\output.txt"))
        {
            while (true)
            {
                string line = readingResult.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line);
            }
        }
    }
}
