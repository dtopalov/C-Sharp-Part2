//Problem 9.* Binary floating-point

//Write a program that shows the internal binary representation of given 
//32-bit signed floating-point number in IEEE 754 format (the C# type float).

using System;

class BinaryFloat
{
    static void Main()
    {
        Console.Write("Enter a floating-point number: ");
        float input = float.Parse(Console.ReadLine());

        string inputToBinary = FloatToBinary(input);

        //Print the result in the following manner: the first bit is the sign (0 for positive, 1 for negative)
        //the next 8 bits are the exponent, the rest are the mantissa

        Console.WriteLine("Number: {0}\nSign: {1} Exponent: {2} Mantissa: {3}", input, inputToBinary[0], 
            inputToBinary.Substring(1, 8), inputToBinary.Substring(9, 22));
    }

    static string FloatToBinary(float number)
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

