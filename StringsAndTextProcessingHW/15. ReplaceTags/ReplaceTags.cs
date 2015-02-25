//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string 
//all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Linq;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter the HTML document: ");
        string input = Console.ReadLine();
        var inputSB = new StringBuilder();
        bool inATag = false;
        for (int i = 0; i < input.Length; i++)
        {
            inputSB.Append(input[i]);
            if (i > 0 && input[i] == 'a' && input[i - 1] == '<')
            {
                inATag = true;
            }
            if (inATag && input[i] == '>')
            {
                inputSB[inputSB.Length - 1] = ']'; //replaces the closing > with a ] only if it closes an <a> tag
                inputSB.Remove(inputSB.Length - 2, 1); //removes the " before the closing bracket
                inATag = false;
            }
        }
        inputSB.Replace("<a href=\"", "[URL=").Replace("</a>", "[/URL]");
        Console.WriteLine(inputSB);
    }
}
