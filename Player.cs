using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Morgan_Daniel
{
    class Player
    {

        public int Health { get; set; } //automati   property called health of integer type

        public string GamerTag { get; } //property called Gmaertag with getter of string type

        public Player(int healthParam, string nameParam) //constructor that take one in parameter and one string parameter.
        {
            Health = healthParam; //assigns
            GamerTag = nameParam; //assigns
        }

        public void JoinGame(Game game, Queue<Player> queue) //public method  called joingame that takes two parameters
        {
            if(game.CurrentPlayers == game.MaxPlayers) // if game's current players is equal to max playrs, then add 'this' player to queue
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!"); //prints Joining game
                game.CurrentPlayers++; //else prints joining game
            }
        }

        public override string ToString() //override the tostring method and return gamertag
        {
            return GamerTag;
        }
    }
}
