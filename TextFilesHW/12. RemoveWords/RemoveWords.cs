//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text;

class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader sr;
            string[] words;
            string[] cleanTxt;

            sr = new StreamReader(@"..\..\wordstoremove.txt");
            using (sr)
            {
                words = (sr.ReadToEnd()).Split(' ');
            }

            sr = new StreamReader(@"..\..\input.txt");
            using (sr)
            {
                cleanTxt = (sr.ReadToEnd()).Split(' ');
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < cleanTxt.Length; i++)
            {
                foreach (var word in words)
                {
                    if (cleanTxt[i].Length >= word.Length)
                    {
                        if (cleanTxt[i] == word)
                        {
                            cleanTxt[i] = string.Empty;
                        }
                    }
                }

                if (cleanTxt[i] == string.Empty)
                {
                    result.Append(string.Empty);
                }
                else
                {
                    result.Append(cleanTxt[i] + " ");
                }
            }

            StreamWriter sw = new StreamWriter(@"..\..\cleanTxt.txt");

            using (sw)
            {
                sw.Write(result.ToString());
            }
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Not enough memory");
            return;
        }
        catch (IOException)
        {
            Console.WriteLine("Can not open file");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Value exceeding the capacity");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("Buffer is full");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Can not write buffer contents");
        }
    }
}
