//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortStrings
{
    static void Main()
    {
        Console.Write("Enter strings, separated by space (one two three ...): ");
        string input = Console.ReadLine(); // or comment this line and uncomment the next to use this array of strings:
        //string input = "Write a method that sorts the array by the length of its elements";
        string[] inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Initial array: [{0}]", string.Join(", ", inputArr));
        inputArr = inputArr.OrderBy(x => x.Length).ToArray();
        Console.WriteLine("Array in ascending order (shortest first):\n[{0}]\n" +
                          "Array in descending order (longest first):\n[{1}]", string.Join(", ", inputArr), string.Join(", ", inputArr.Reverse()));
    }
}

