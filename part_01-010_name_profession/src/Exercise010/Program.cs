namespace Exercise010
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n" + "Give a name for main character:");
            string a = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string b = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" + $"Once upon a time there was a {b} called {a}\n" + $"On her way to work, {a} often pondered what being {b} meant to them.\n" + $"When you work as a {b} you meet interesting people.\n" + $"{a} enjoys their work as {b}, The end.");
        }
    }
}
