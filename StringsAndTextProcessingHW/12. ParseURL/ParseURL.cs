//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string input = Console.ReadLine();

        var protocol = new StringBuilder();
        var server = new StringBuilder();
        var resource = new StringBuilder();

        int i = 0;

        while (input[i] != ':')
        {
            protocol.Append(input[i]);
            i++;
        }
        i += 3;
        while (input[i] != '/')
        {
            server.Append(input[i]);
            i++;
        }
        while (i < input.Length)
        {
            resource.Append(input[i]);
            i++;
        }

        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
    }
}

