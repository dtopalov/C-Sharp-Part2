//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        int[] firstTestArray = new int[] {3, 2, 2, 5, 1, -8, 7, 2};
        int firstTest = 2;

        double[] anotherTestArray = new double[]{5.5, 0.12, 6.3, 0.12};
        double anotherTest = 0.12;

        Console.WriteLine("The number {0} appears {1} times in the array\n[{2}].", 
            firstTest, CountAppearances(firstTestArray, firstTest).Length, string.Join(", ", firstTestArray)); //test w/ int
        Console.WriteLine("The number {0} appears {1} times in the array\n[{2}].",
            anotherTest, CountAppearances(anotherTestArray, anotherTest).Length, string.Join(", ", anotherTestArray)); //test w/ double
    }

    static int[] CountAppearances(int[] array, int number)
    {
        return Array.FindAll(array, x => x == number);
    }

    static long[] CountAppearances(long[] array, long number)
    {
        return Array.FindAll(array, x => x == number);
    }

    static double[] CountAppearances(double[] array, double number)
    {
        return Array.FindAll(array, x => x == number);
    }

    static float[] CountAppearances(float[] array, float number)
    {
        return Array.FindAll(array, x => x == number);
    }
}
