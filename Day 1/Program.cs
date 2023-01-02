using System.ComponentModel;

namespace Day_1
{   
    public class Program
    {
        static void Main(string[] args)
        {
                   
            var filepath = @"D:\Projects\AdventOfCode2022\Day 1\Calories.txt";      
            File.AppendAllText(filepath, Environment.NewLine);

            var caloriesPuzzle = new CaloriesPuzzle();

            caloriesPuzzle.SumCaloriesPerElf(filepath);
            caloriesPuzzle.GetMostCalories();
            caloriesPuzzle.SumTopThree();
            
            
            Console.WriteLine("The most calories an elf is carrying: {0}", caloriesPuzzle.MostCalories);
            Console.WriteLine("Top three elves are carrying {0} calories total", caloriesPuzzle.TopThreeTotal);
        }
    }
}