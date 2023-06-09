﻿﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManager4
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The list of all players.
        /// </summary>
        private List<Player> playerList;

        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            //Create a new instance of the player listing program
            Program prog = new Program();
            //Start the program instance
            prog.Start();
        }

        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        private Program()
        {
            //Initialize the player list with two players using collection
            //initialization syntax
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }

        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        private void Start()
        {
            //We keep the user's option here
            string option;

            // Main program loop
            do
            {
                //Show menu and get user option
                ShowMenu();
                option = Console.ReadLine();

                //Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        //Insert player
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    case "5":
                        //List players sorted by name in ascending order
                        ListPlayersSortedByName(true);
                        break;
                    case "6":
                        //List players sorted by name in descending order
                        ListPlayersSortedByName(false);
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                // Wait for the user to press a key...
                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");

                // Loop keeps going until the player chooses to quit (option 4)
            } while (option != "4");
        }

        /// <summary>
        /// List player names more easily
        /// </summary>
        /// <param name="ascending"></param>
        private void ListPlayersSortedByName(bool ascending)
        {
            Console.WriteLine("\nList of players sorted by name");
            Console.WriteLine("-------------\n");

            // Create a comparer for sorting players by name
            var comparer = new CompareByName(ascending);

            // Sort the players using the comparer
            var sortedPlayers = playerList.OrderBy(p => p, comparer);

            // Show each player in the sorted list
            foreach (Player p in sortedPlayers)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Shows the main menu.
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Quit\n");
            Console.Write("Your choice > ");
        }

        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            // Variables
            string name;
            int score;
            Player newPlayer;

            // Ask for player info
            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());

            // Create new player and add it to list
            newPlayer = new Player(name, score);
            playerList.Add(newPlayer);
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>
        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-------------\n");

            // Show each player in the enumerable object
            foreach (Player p in playersToList)
            {
                Console.WriteLine($" -> {p.Name} with a score of {p.Score}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            // Minimum score user should have in order to be shown
            int minScore;

            // Ask the user what is the minimum score
            Console.Write("\nMinimum score player should have? ");
            minScore = Convert.ToInt32(Console.ReadLine());

            // Get players with score higher than the user-specified value
            var playersWithScoreGreaterThan = playerList.Where(p => p.Score > minScore);

            // Sort the players by score in descending order
            playersWithScoreGreaterThan = playersWithScoreGreaterThan.OrderByDescending(p => p.Score);

            // List all players with score higher than the user-specified value
            ListPlayers(playersWithScoreGreaterThan);
        }
    }
}