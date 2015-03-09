//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.

using System.IO;
using System.Text;


class ExtractText
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\sample.xml");
        string input = string.Empty;
        StringBuilder result = new StringBuilder();

        using (sr)
        {
            input = sr.ReadToEnd();
        }

        bool inTag = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                inTag = true;
            }
            if (!inTag)
            {
                result.Append(input[i]);
            }
            if (input[i] == '>')
            {
                inTag = false;
            }
        }

        StreamWriter sw = new StreamWriter(@"..\..\result.txt"); //check the file

        using (sw)
        {
            sw.WriteLine(result.ToString());
        }
    }
}
