//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Linq;

class DeleteLines
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\sample_text.txt"); //check the contents of the file before
                                                                      //execution...
        while (sr.ReadLine() != null)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\temp.txt", true))
            {
                sw.WriteLine(sr.ReadLine());
            }
        }

        sr.Close();
        File.Delete(@"..\..\sample_text.txt");
        File.Move(@"..\..\temp.txt", @"..\..\sample_text.txt"); //...and after
        File.Delete(@"..\..\temp.txt");
    }
}
