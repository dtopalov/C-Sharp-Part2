//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
//of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter a string to be encoded: ");
        string input = Console.ReadLine();
        Console.Write("Enter encryption key: ");
        string cipher = Console.ReadLine();
        var encodedInput = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            encodedInput.Append((char)(input[i]^cipher[i % cipher.Length])); //encoding
        }
        Console.WriteLine("Encoded text: {0}", encodedInput);

        var decodedText = new StringBuilder();

        for (int i = 0; i < encodedInput.Length; i++)
        {
            decodedText.Append((char)(encodedInput[i] ^ cipher[i % cipher.Length])); //decoding
        }
        Console.WriteLine("Decoded text: {0}", decodedText);
    }
}
