using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace yatzy
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var consoleService = new ConsoleOperations();
            
            consoleService.Write("PLease enter your name");
            var name = consoleService.Read();
            var player = new Player(name, consoleService);
            var game = new Game(player, consoleService);
            game.Start();

        }
    }
}