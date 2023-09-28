using System;
using System.Collections.Generic;

namespace Queues_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49); // game object set max players to 50 and current players to 49

            Queue<Player> waitingToJoinQ = new Queue<Player>(); // queue of players objects

            Player p1 = new Player(100, "MMSix");  // 4 players with full heatlh and gamertag
            Player p2 = new Player(100, "xXAwesomenessXx"); 
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "xXJoeXx");

            p1.JoinGame(myGame, waitingToJoinQ); //calls joingame on all players passing thorough the game and queue as arguements
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in da Q:");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player); //prints players in da queue
            }

            myGame.KickPlayer(); // calls kickplayer on the game
            myGame.CheckQueue(waitingToJoinQ); // calls checkqueue on the game


            Console.WriteLine("\nPlayers in da Q:"); //on a new line prints players in da q for each player that is in queue
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

        }
    }
}
