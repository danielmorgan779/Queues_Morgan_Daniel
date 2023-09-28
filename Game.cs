using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Queues_Morgan_Daniel
{
    class Game
    {

        public int MaxPlayers { get; } //property called maxplayers with getter

        public int CurrentPlayers { get; set; } //property called currentplayers with getter and setter

        public Game(int maxP, int currentP) //constructor with two int parameters, maxPlayers and currentPlayers
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer() // method called KickPlayer, decrements by 1
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue) // method called CheckQueue, takes a queue<player> parameter
        {
            if (CurrentPlayers < MaxPlayers) // iff currentplayers is less than maxplayers, then it checks if the queue has elements in it
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue(); //IF queue has players in it, it will dequeue on the queue and increment current players by 1 and prints below
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }


    }
}
