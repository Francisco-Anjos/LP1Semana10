using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        /// <summary>
        /// Main Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Hashset
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            //Player 1
            Player player1 = new Player{Type =PlayerType.Tank, Name ="Ana"};
            //Player 2
            Player player2 = new Player{Type =PlayerType.Slayer, Name ="Paulo"};
            //Player 3
            Player player3 = new Player{Type =PlayerType.Tank, Name ="Ana"};

            //Add player 1
            setOfPlayers.Add(player1);
            //Add player 2
            setOfPlayers.Add(player2);
            //Add player 3
            setOfPlayers.Add(player3);

            //For each player inside the list
            foreach (Player player in setOfPlayers)
            {
                //Write their name and class
                Console.WriteLine($"{player.Name} is a {player.Type}");
            }
        }  
    }
}
