//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractEmails
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

        var emails = new List<string>();
        var emailAddress = new StringBuilder();
        char[] allowedForName = { '!', '#', '"', '$', '%', '.', '&', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~' };

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '@')
            {
                int index = i - 1;
                while (index >= 0 && (Char.IsLetterOrDigit(input[index])
                    || allowedForName.Contains(input[index])))
                {
                    emailAddress.Insert(0, input[index]);
                    index--;
                }
                emailAddress.Append('@');
                index = i + 1;
                while (index < input.Length && (Char.IsLetterOrDigit(input[index])
                    || input[index] == '-' || input[index] == '.'))
                {
                    emailAddress.Append(input[index]);
                    index++;
                }
                i = index;
            }
            if (emailAddress.Length > 0)
            {
                emails.Add(emailAddress.ToString().TrimEnd(new []{'.','-'}));
                emailAddress.Clear();    
            }
        }

        Console.WriteLine(string.Join(", ", emails));
    }
}
