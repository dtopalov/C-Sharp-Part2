//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatTxtFiles
{
    static void Main()
    {
        using (StreamWriter sw1 = new StreamWriter("file1.txt"))
        {
            sw1.WriteLine("This is the first text file's content.");
        }
        using (StreamWriter sw2 = new StreamWriter("file2.txt"))
        {
            sw2.WriteLine("This is the second text file's content.");
        }
        using (StreamWriter sw3 = new StreamWriter("result.txt"))
        {
            sw3.WriteLine(new StreamReader("file1.txt").ReadToEnd());
            sw3.WriteLine(new StreamReader("file2.txt").ReadToEnd());
        }

        //check contents of the three text files in solution explorer - show all files --> bin folder --> debug folder
    }
}