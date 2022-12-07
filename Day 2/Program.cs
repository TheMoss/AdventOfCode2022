using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Strategies strategies = new Strategies();
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            game.Path = @"D:\Projects\AdventOfCode2022\Day 2\RockPaperScissors.txt";

            while (true)
            {
                game.GameMenu();
                game.Play(strategies.FirstStrategy, strategies.SecondStrategy);                
            }
            
        }

    }
}
