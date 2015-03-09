//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
{
    static void Main()
    {
        using (FileStream fs = File.Open(@"..\..\input.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
        using (BufferedStream bs = new BufferedStream(fs))
        using (StreamReader sr = new StreamReader(bs))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                line = Regex.Replace(line, "\\b" + "start" + "\\b", "finish"); //replace only where start is not a part of another word
                using (StreamWriter sw = new StreamWriter(@"..\..\output.txt", true)) //writing the text after changes to a new file    
                {                                                                     //so that the files can be checked for the differences
                    sw.WriteLine(line);
                }
            }
        }
    }
}
