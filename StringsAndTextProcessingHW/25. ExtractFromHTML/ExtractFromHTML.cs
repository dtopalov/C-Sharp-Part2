//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;

class ExtractFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = string.Empty;
        var inputLines = new List<string>();

        do //allows multiple lines of input, press Enter twice after the last line
        {
            input = Console.ReadLine().Trim();
            inputLines.Add(input);
        } while (input != string.Empty);

        input = string.Join(" ", inputLines);
        string title = string.Empty;
        string text = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 7 && input.Substring(i, 7) == "<title>")
            {
                i += 7;
                while (input[i] != '<')
                {
                    title += input[i];
                    i++;
                }
            }
            if (input[i] == '<')
            {
                while (input[i] != '>')
                {
                    i++;
                }
            }
            if (i < input.Length && input[i] != '>')
            {
                text += input[i];    
            }
        }

        Console.WriteLine("Title: {0}\n\nText: {1}", title, text.Trim());
    }
}
