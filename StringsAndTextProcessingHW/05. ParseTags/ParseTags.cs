//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags 
//<upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string input = Console.ReadLine();
        var result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 8 && input.Substring(i, 8) == "<upcase>") //if we reach tag <upcase>
            {
                input = input.Remove(i, 8); //remove it
                while (i < input.Length - 9 && input.Substring(i, 9) != "</upcase>") //until we don't reach closing tag
                {
                    result.Append(Char.ToUpper(input[i])); //make every character uppercase and append it to the result
                    i++;
                }
                input = input.Remove(i, 9); //remove the closing tag
            }
            result.Append(input[i]); //append every other character to the result
        }

        Console.WriteLine(result.ToString());
    }
}
