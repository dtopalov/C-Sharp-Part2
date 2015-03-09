//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;
using System.Text;

class PrefixTest
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\input.txt");
        StringBuilder result = new StringBuilder();

        using (sr)
        {
            string text = sr.ReadToEnd();
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 4)
                {
                    if (words[i].Substring(0, 4) == "test")
                    {
                        words[i] = string.Empty;
                        result.Append(string.Empty);
                    }
                    else
                    {
                        result.Append(words[i] + " ");
                    }
                }
                else
                {
                    result.Append(words[i] + " ");
                }
            }
        }

        StreamWriter sw = new StreamWriter(@"..\..\result.txt"); //check result file

        using (sw)
        {
            sw.Write(result.ToString());
        }
    }
}
