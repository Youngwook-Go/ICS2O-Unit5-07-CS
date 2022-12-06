// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets user number and do proper calculation

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int number;
        int answer = 0;

        Console.WriteLine("This program gets user number to answer properly.");
        Console.WriteLine("n = 1 + 2 + 3 ... + x-1 + x-2 + x-3.\n");

        Console.Write("Enter a random number : "); number = Convert.ToInt32(Console.ReadLine());

        // output
        for (int count = 0; count < number + 1; count++)
        {
            answer = answer + count;
        }

        Console.WriteLine("\nThe answer is : " + answer + ".");
        Console.WriteLine("\ndone.");
    }
}
