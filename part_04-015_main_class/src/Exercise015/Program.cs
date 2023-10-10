namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {

                string name = Console.ReadLine();
                Console.Write("Name: ");
                //Console.Write(name);
                if (name == "")
                {
                    Console.Write("\n");
                    break;
                }
                else
                {
                    items.Add(new Item(name));
                }
            }

            foreach (Item name in items)
            {
                // Print using ToString
                Console.WriteLine(name.ToString());


            }

        }
    }
}