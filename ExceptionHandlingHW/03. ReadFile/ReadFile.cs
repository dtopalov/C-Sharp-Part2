//Problem 3. Read file contents

using System;
using System.IO;
using System.Text;

class ReadFile
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"C:\Windows\win.ini", Encoding.UTF8))
            {
                string fileContents = sr.ReadToEnd();
                Console.WriteLine(fileContents);
            }
        }

        catch (ArgumentException)
        {
            Console.WriteLine("StreamReader invoked with wrong or null arguments");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method or functionality is not supported");
        }
    }
}
