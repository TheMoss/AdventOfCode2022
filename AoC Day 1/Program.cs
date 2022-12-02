using System.ComponentModel;

namespace AoC_Day_1
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> caloriesPerElf = new List<int>();       
            string filepath = @"D:\Projects\AdventOfCode2022\AoC Day 1\Calories.txt";
            int calories = 0;
            
            foreach (string line in System.IO.File.ReadLines(filepath))
            {

                if (!String.IsNullOrEmpty(line) )
                {
                    int l = Int32.Parse(line);
                    calories += l;                    
                }
                else
                {
                    caloriesPerElf.Add(calories);
                    calories = 0;                                                     
                }
            }
            caloriesPerElf.Add(calories);
            caloriesPerElf.Sort();
            caloriesPerElf.Reverse();
            int mostCalories = caloriesPerElf[0];
            int topThree = caloriesPerElf[0] + caloriesPerElf[1] + caloriesPerElf[2];
            
            Console.WriteLine("The most calories an elf is carrying: {0}", mostCalories);
            Console.WriteLine("Top three elves are carrying {0} calories total", topThree);
        }
    }
}