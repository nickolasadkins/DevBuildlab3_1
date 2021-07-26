using System;

namespace Lab3_1
{
    class Program
    {
        static bool KeepGoing()
        {

            while (true)
            {

                Console.WriteLine("Would you like to know about another student ? (enter 'yes' or 'no'):");

                string response = Console.ReadLine();
                response = response.ToLower();

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");

                }
            }
        }

        static void Main(string[] args)
        {
            string[] names = { "Jared Franklin", "Zack Parr", "Jordan Begian", "Aly Hansen", "Rachelle Leslie" };
            string[] food = { "Ramen", "Chicken Nuggets", "Pizza", "Burritos", "Empanadas" };
            string[] position = { "Team Leader", "Underwriter", "Copywriter", "Bartender", "Team Relations Specialist" };

            do
            {

                Console.WriteLine("Welcome to our Dev.Build Class! Which student would you like to learn more about?");
                Console.Write("Please enter a number 1-5:");
                string response = Console.ReadLine();
                Console.WriteLine();

                int choice = int.Parse(response) - 1;
                
                Console.WriteLine($"You chose {names[choice]}! What would you like to know about them? \n(Please enter 'favorite food' or 'previous title'):");

                string response1 = Console.ReadLine();

                if (response1 == "favorite food")
                {
                    Console.WriteLine($"\n{names[choice]}'s favorite food is {food[choice]}!");
                }
                else if (response1 == "previous title")
                {
                    Console.WriteLine($"\n{names[choice]}'s previous title was {position[choice]}");
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. \n(Please enter 'favorite food' or 'previous title'");
                }
            }
            while (KeepGoing());
        }
    }
}
