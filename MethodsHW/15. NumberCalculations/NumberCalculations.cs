using System;
using System.Collections.Generic;
using System.Linq;

class NumberCalculations
{
    static void Main()
    {
        int[] arrayOfInts = {2, 5, 10, 20, -5, 7, -1};
        double[] arrayOfDoubles = { 2.2, 5.5, 10.12, 20.454, -5.34, 7.3545, -1.542524 };
        float[] arrayOfFloats = { 2.2f, 5.5f, 10.12f, 20.454f, -5.34f, 7.3545f, -1.542524f };
        //methods, invoked with parameter array of ints
        Console.WriteLine("Methods working with Int:\nMin: {0}\nMax: {1}\nAverage: {2}\nProduct: {3}\n", 
            ShowMin(arrayOfInts), ShowMax(arrayOfInts), CalcAverage(arrayOfInts), CalcProduct(arrayOfInts));
        //methods, invoked with parameter array of doubles
        Console.WriteLine("Same methods working with Double:\nMin: {0}\nMax: {1}\nAverage: {2}\nProduct: {3}\n",
            ShowMin(arrayOfDoubles), ShowMax(arrayOfDoubles), CalcAverage(arrayOfDoubles), CalcProduct(arrayOfDoubles));
        //methods, invoked with parameter array of floats
        Console.WriteLine("Same methods working with Float:\nMin: {0}\nMax: {1}\nAverage: {2}\nProduct: {3}\n",
            ShowMin(arrayOfFloats), ShowMax(arrayOfFloats), CalcAverage(arrayOfFloats), CalcProduct(arrayOfFloats));
        //can be invoked with parameters of any number type
    }

    static T ShowMin<T>(params T[] array)
    {
        return array.Min();
    }
    static T ShowMax<T>(params T[] array)
    {
        return array.Max();
    }

    static double CalcAverage<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum/(double)array.Length;
    }
    static T CalcProduct<T>(T[] array)
    {
        dynamic product = 1;
        foreach (var item in array)
        {
            product *= item;
        }
        return product;
    }
}
