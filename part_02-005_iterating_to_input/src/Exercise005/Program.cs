﻿namespace Exercise005
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count <= a)
            {
                Console.WriteLine(count);
                count++;
            }
        }
    }
}
