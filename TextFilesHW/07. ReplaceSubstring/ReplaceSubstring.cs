using System.IO;

class ReplaceSubstring
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
                line = line.Replace("start", "finish");
                using (StreamWriter sw = new StreamWriter(@"..\..\output.txt", true)) //writing the text after changes to a new file    
                {                                                               //so that the files can be checked for the differences
                    sw.WriteLine(line);
                }
            }
        }
    }
}
