﻿namespace Exercise022
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string fileName = Console.ReadLine();
            string text = File.ReadAllText(fileName);
            Console.WriteLine(text);
        }
    }
}