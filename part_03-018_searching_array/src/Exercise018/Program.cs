﻿namespace Exercise018
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT CHANGE THE FOLLOWING CODE!
            int[] array = new int[10];
            array[0] = 6;
            array[1] = 2;
            array[2] = 8;
            array[3] = 1;
            array[4] = 3;
            array[5] = 0;
            array[6] = 9;
            array[7] = 7;

            Console.WriteLine("Search for?");
            int searching = Convert.ToInt32(Console.ReadLine());

            // Implement the search functionality here

            for (int ind = 0; ind < array.Length; ind++)
            {
                if (array[ind] == searching)
                {
                    Console.WriteLine($"{searching} is at index {ind}.");
                    return;
                }

            }
            Console.WriteLine($"{searching} was not found.");



        }
    }
}
