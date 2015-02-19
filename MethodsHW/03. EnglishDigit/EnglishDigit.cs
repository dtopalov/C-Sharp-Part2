//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        Console.WriteLine(LastDigitAsAWord(input));
    }

    static string LastDigitAsAWord(string number)
    {
        string[] digitNames = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
        return digitNames[int.Parse(number[number.Length - 1].ToString())];
    }
}

