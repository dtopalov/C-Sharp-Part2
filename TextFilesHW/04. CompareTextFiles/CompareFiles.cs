//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareFiles
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;
        StreamReader sr1 = new StreamReader(@"..\..\file1.txt");
        StreamReader sr2 = new StreamReader(@"..\..\file2.txt");
        while (true)
        {
            string line1 = sr1.ReadLine();
            string line2 = sr2.ReadLine();
            if (line1 == null || line2 == null)
            {
                break;
            }
            if (line1 == line2)
            {
                sameLines++;
            }
            else
            {
                differentLines++;
            }
        }
        sr1.Close();
        sr2.Close();
        Console.WriteLine("Same lines: {0}\nDifferent lines: {1}", sameLines, differentLines);
    }
}

