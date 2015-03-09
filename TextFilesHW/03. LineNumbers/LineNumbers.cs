//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter(@"../../result.txt"))
        {
            StreamReader sr = new StreamReader(@"../../sample_text.txt");
            int counter = 1;
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                sw.WriteLine("{0, 2}. {1}", counter, line);
                counter++;
            }
            sr.Close();
        }
        using (StreamReader sr = new StreamReader(@"../../result.txt")) //print the content of the result file
        {
            string resultContent = sr.ReadToEnd();
            Console.WriteLine(resultContent);
        }
    }
}
