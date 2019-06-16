using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init Variables
            string theMatrix, system, neo, enemy = "", inside = "", save = "", unplugged = "", fight = "";
            string[] profession = new string[4], adj = new string[2];

            // Get Input From User
            Console.WriteLine("Welcome user!");
            Console.WriteLine("Let's Play a game of madlibs!");
            Console.WriteLine("Please share with me your name?");
            neo = Console.ReadLine();

            // Getting the matrix variable from user
            Console.WriteLine($"Hello {neo}! Are you ready? What is something you want to know more" +
                $"about?");
            theMatrix = Console.ReadLine();

            // Getting system variable from user
            Console.WriteLine($"Oooh! you want to know more about {theMatrix} huh?");
            Console.WriteLine($"Okay well first, tell me what you already know about {theMatrix}");
            Console.WriteLine($"What noun would you categorize {theMatrix} as:");
            system = Console.ReadLine();

            // Getting enemy variable from user
            Console.WriteLine($"Give me an opposing noun to {system}");
            enemy = Console.ReadLine();

            // Getting inside variable from user
            Console.WriteLine($"Now give me any relaxing noun (present tense)");
            inside = Console.ReadLine();

            // Getting all professions from user
            Console.WriteLine($"Okay, now I need 4 profressions relating to {system}");

            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"Profession (plural) {i + 1} / {profession.Length}");
                profession[i] = Console.ReadLine();
            }

            // Getting the save variable
            Console.WriteLine($"Give me a hero-related verb (present tense):");
            save = Console.ReadLine();

            // Getting the unplugged variable
            Console.WriteLine($"Now give me a verb that makes you think about relief (past tense):");
            unplugged = Console.ReadLine();

            // Getting the adjectives
            Console.WriteLine($"Lastly I need 2 dystopian adjectives");

            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine($"Adjective {i + 1} / {adj.Length}:");
                adj[i] = Console.ReadLine();
            }

            // Getting the fight variable
            Console.WriteLine($"& a verb:");
            fight = Console.ReadLine();

            // Init Story
            string madlibsStory =
            $"{theMatrix} is a {system}, {neo}. That {system} is our {enemy}. " +
            $"But when you're {inside}, you look around, what do you see? " +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}. The very minds " +
            $"of the people we are trying to {save}. But until we do, " +
            $"these people are still a part of that {system} and that makes " +
            $"them our {enemy}. You have to understand, most of these people " +
            $"are not ready to be {unplugged}. And many of them are so {adj[0]}, " +
            $"so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.";

            // Print Story
            Console.WriteLine(madlibsStory);
            Console.ReadKey();
        }
    }
}
