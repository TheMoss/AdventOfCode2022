using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class CaloriesPuzzle
    {
        public int Calories { get; set; }
        public int MostCalories { get; set; }
        public int TopThreeTotal { get; set; }
        public List<int> CaloriesPerElf { get; set; } = new List<int>();

        public void SumCaloriesPerElf(string filepath)
        {
            foreach (string line in System.IO.File.ReadLines(filepath))
            {

                if (!String.IsNullOrEmpty(line))
                {
                    int l = Int32.Parse(line);
                    Calories += l;
                }
                else
                {
                    CaloriesPerElf.Add(Calories);
                    Calories = 0;
                }
            }
        }

        public void GetMostCalories()
        {
            CaloriesPerElf.Sort();
            CaloriesPerElf.Reverse();

            MostCalories = CaloriesPerElf[0];
        }
         
        public void SumTopThree()
        {
            TopThreeTotal = CaloriesPerElf[0] + CaloriesPerElf[1] + CaloriesPerElf[2];
        }
    }
}
