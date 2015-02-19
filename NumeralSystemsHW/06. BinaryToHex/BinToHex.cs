//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHex
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binary = Console.ReadLine();

        Console.WriteLine("The hexadecimal representation of {0}\nis: {1}", binary, ConvertBinToHex(binary));
    }

    static string ConvertBinToHex(string binary)
    {
        string hex = "";
        if (binary.Length%4 != 0)
        {
            binary = new string('0', 4 - binary.Length%4) + binary; //filling up the number with zeroes in front, so that
        }                                                           //it can be divided in groups of 4 bits, each of which
        for (int i = 0; i < binary.Length; i+=4)                    //represents a digit of the hex number
        {
            string hexDigit = binary.Substring(i, 4);
            switch (hexDigit)
            {
                case "0000":
                    hex += 0; 
                    break;
                case "0001":
                    hex += 1;
                    break;
                case "0010":
                    hex += 2;
                    break;
                case "0011":
                    hex += 3;
                    break;
                case "0100":
                    hex += 4;
                    break;
                case "0101":
                    hex += 5;
                    break;
                case "0110":
                    hex += 6;
                    break;
                case "0111":
                    hex += 7;
                    break;
                case "1000":
                    hex += 8;
                    break;
                case "1001":
                    hex += 9;
                    break;
                case "1010":
                    hex += "A";
                    break;
                case "1011":
                    hex += "B";
                    break;
                case "1100":
                    hex += "C";
                    break;
                case "1101":
                    hex += "D";
                    break;
                case "1110":
                    hex += "E";
                    break;
                case "1111":
                    hex += "F";
                    break;
            }
        } 
        return hex;
    }
}
