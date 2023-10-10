namespace Exercise002
{
    using System;

    public class UserInterface
    {
        private JokeManager jokeManager;
        public UserInterface(JokeManager jokeManager)
        {
            this.jokeManager = jokeManager;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

                string command = Console.ReadLine();

                if (command == "X")
                {
                    break;
                }

                if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string joke = Console.ReadLine();
                    jokeManager.AddJoke(joke);
                }
                else if (command == "2")
                {
                    Console.WriteLine("Drawing a joke.");
                    jokeManager.DrawJoke();

                }
                else if (command == "3")
                {
                    jokeManager.PrintJokes();
                }

            }
        }
    }
}