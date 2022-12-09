using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Rucksack
    {
                
        public int PartialSum { get; set; }
        public int TotalFirstSum { get; set; }
        public int TotalSecondSum { get; set; }


        public (string firstHalf, string secondHalf) GetHalves(string row)
        {
            return
                (
                    row.Substring(0, (row.Length / 2)),
                    row.Substring(row.Length / 2, row.Length / 2)
                );

        }


        public int GetPriority(IEnumerable<char> intersectingItems)
        {
            PartialSum = intersectingItems.Select(c => Char.IsUpper(c) ? c - 38 : c - 96).Sum();
            return PartialSum;
        }


    }
}
