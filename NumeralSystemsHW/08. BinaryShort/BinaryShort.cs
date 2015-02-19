//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a short number: ");
        short input = short.Parse(Console.ReadLine());

        string inputToBinary = ShortToBinary(input);

        //Print the result in the following manner: the first bit is the sign (0 for positive, 1 for negative)
        //the next 15 bits are for the number

        Console.WriteLine("Number: {0}\nSign: {1} Number: {2}", input, inputToBinary[0],
            inputToBinary.Substring(1, 15));
    }
    static string ShortToBinary(short number)
    {
        byte[] bytesInput = BitConverter.GetBytes(number); //get the number as an array of 4 bytes
        string inputToBinary = "";
        for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
        {                                           //with zeroes to get 8 bits for each byte
            inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
        }
        return inputToBinary;
    }
}
