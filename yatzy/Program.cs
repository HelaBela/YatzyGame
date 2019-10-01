using System;
using System.Collections.Generic;
using System.Linq;

namespace yatzy
{
    class Program
    {
         
        static void Main(string[] args)
        {
            
            Console.WriteLine("PLease enter your name");
            var name = Console.ReadLine();
            var player = new Player(name);
            var game = new Game(player);
            game.Start();

        }
    }
}