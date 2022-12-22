using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_4
{
    internal class Cleaning
    {
        private int[]? _numbers;
        public int[]? Numbers { get; set; }
        private int _counterFullyOverlapped;
        public int CountFullyOverlapped { get; set; }
        private int _countPartiallyOverlapped;
        public int CountPartiallyOverlapped { get; set; }
        public int[] ParseFile(string filepath)
        {
            char[] delimiters = { '\n', ',', '-' };
            string readPairs = File.ReadAllText(filepath);
            string[] splitPairs = readPairs.Split(delimiters);
            Numbers = splitPairs.Select(int.Parse).ToArray();
            return this.Numbers;
        }
        public int GetFullOverlap()
        {

            for (int i = 0; i < Numbers.Length - 1; i += 4)
            {
                if ((Numbers[i] >= Numbers[i + 2] && Numbers[i + 1] <= Numbers[i + 3]) || (Numbers[i] <= Numbers[i + 2] && Numbers[i + 1] >= Numbers[i + 3]))
                {
                    CountFullyOverlapped++;
                }
                else
                {
                    continue;
                }
            }
            return CountFullyOverlapped;
        }

        public int GetPartialOverlap()
        {
            for (int i = 0; i < Numbers.Length - 1; i += 4)
            {
                if ((Numbers[i+1] >= Numbers[i+2] && Numbers[i] <= Numbers[i+3]) || (Numbers[i] <= Numbers[i+3] && Numbers[i+2] <= Numbers[i+1]))
                {
                    CountPartiallyOverlapped++;
                }
                else
                {
                    continue;
                }
            }
            return CountPartiallyOverlapped;
        }
    }
}    