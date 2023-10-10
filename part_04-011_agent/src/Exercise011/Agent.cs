namespace Exercise011
{
    using System;
    public class Agent
    {
        public string firstName;
        public string lastName;

        public Agent(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            // Should return for example "My name is Bond. James Bond."

            return "My name is " + this.lastName + ". " + this.firstName + " " + this.lastName + ".";
        }
    }
}