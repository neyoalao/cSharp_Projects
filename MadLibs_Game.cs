using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program creates a mad libs word game...
            Author: Olaniyi Alao...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");


            // Give the Mad Lib a title:
            string title = "Welcome to the game!";

            Console.WriteLine(title);

            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            // User adjectives 
            Console.Write("Enter your first adjective: ");
            string adje1 = Console.ReadLine();

            Console.Write("Enter your second adjective: ");
            string adje2 = Console.ReadLine();

            Console.Write("Enter your third adjective: ");
            string adje3 = Console.ReadLine();

            // User verbs
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            // User nouns
            Console.Write("Enter your first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter your second noun: ");
            string noun2 = Console.ReadLine();


            Console.Write("An animal:");
            string animal = Console.ReadLine();

            Console.Write("A food:");
            string food = Console.ReadLine();

            Console.Write("A fruit:");
            string fruit = Console.ReadLine();

            Console.Write("A superhero:");
            string superhero = Console.ReadLine();

            Console.Write("A country:");
            string country = Console.ReadLine();

            Console.Write("A dessert:");
            string dessert = Console.ReadLine();

            Console.Write("A year:");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {adje1}. 'It is going to be a {adje2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adje3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";



            // Print the story:
            Console.WriteLine(story);

        }
    }
}
