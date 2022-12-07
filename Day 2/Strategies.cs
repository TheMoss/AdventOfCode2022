using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Strategies
    {
        public Dictionary<string, int> FirstStrategy = new Dictionary<string, int>()
            {
                {"AX", 4},//rock rock 1+3
                {"BX", 1},//paper rock 1+0
                {"CX", 7},//scissors rock 1+6
                {"AY", 8},//rock paper 2+6
                {"BY", 5},//paper paper 2+3
                {"CY", 2},//scissors paper 2+0
                {"AZ", 3},//rock scissors 3+0
                {"BZ", 9},//paper scissors 3+6
                {"CZ", 6}//scissors scissors 3+3 
            };

        public Dictionary<string, int> SecondStrategy = new Dictionary<string, int>()
            {
                {"AX", 3},//rock scissors 3+0
                {"BX", 1},//paper rock 1+0
                {"CX", 2},//scissors paper 2+0
                {"AY", 4},//rock rock 1+3
                {"BY", 5},//paper paper 2+3
                {"CY", 6},//scissors scissors 3+3
                {"AZ", 8},//rock paper 2+6
                {"BZ", 9},//paper scissors 3+6
                {"CZ", 7}//scissors rock 1+6 
            };
    }
}
