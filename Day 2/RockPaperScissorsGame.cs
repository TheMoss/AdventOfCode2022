using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Day_2
{
    public class RockPaperScissorsGame
    {
        public string Path;
        public string ChosenStrategy;
        public int Score;
        public string Moves;

        public string GameMenu()
        {
            Console.WriteLine("Which strategy do you choose?");
            Console.WriteLine("Strategy 1: calculate your score for your and your opponet's moves.");
            Console.WriteLine("Strategy 2: calculate your score for predefined game outcomes.");
            Console.WriteLine("Please type in 1 or 2 to pick the strategy.");
            ChosenStrategy = Console.ReadLine();

            if (ChosenStrategy != "1" && ChosenStrategy != "2")
            {
                Console.WriteLine("Error. You have to pick number 1 or 2. Please try again.\n");                
                GameMenu();
            }
            else
            {
                return ChosenStrategy;
                
            }

            return ChosenStrategy;
            
        }

        public int GetMoves(Dictionary<string, int> dictionary)
        {
            foreach (string line in System.IO.File.ReadLines(Path))
            {
                Moves = line.Replace(" ", "");
                Score += dictionary[Moves];
            }

            return Score;
        }

        public void Play(Dictionary<string, int> firstStrategy, Dictionary<string, int> secondStrategy)
        {

            if (ChosenStrategy == "1")
            {
                GetMoves(firstStrategy);
                Console.WriteLine("Your score for strategy number one is: {0}\n", Score);                
            }

            else
            {
                GetMoves(secondStrategy);
                Console.WriteLine("Your score for strategy number one is: {0}\n", Score);
            }

            
        }




    }
}




