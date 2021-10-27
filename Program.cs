using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create your classes first - starting with the Movie class
            //Keep in mind which methods would need to be different per object
            //Use a Store class to run the methods and create the lists - similar to the movie walkthrough we did earlier
            //Use Program to test your stuff per item!  Don't get hung up on a method doing EVERYTHING.


            Blockbuster bb = new Blockbuster();
            

            //////////////////////////////////////
            bool keepGoing = true;
            Console.WriteLine("Welcome to Blockbuster!");

            while (keepGoing)
            {
                Movie rental = bb.CheckOut();
                rental.Play();

                keepGoing = ContinueLoop("Would you like to watch another movie? [y] or [n]\n");
            }
            Console.WriteLine("Thanks for watching - Goodbye!");

        }
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.  Please input \"y\" or \"n\".\n"); 
                return ContinueLoop(question);
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
