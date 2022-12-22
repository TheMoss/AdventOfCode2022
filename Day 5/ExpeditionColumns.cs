using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class ExpeditionColumns
    {
        public string TopSeparateCrates { get; set; } = "";
        public string TopTogetherCrates { get; set; } = "";      

        public void MoveCratesSeparately(string[] input, List<Stack<char>> stackList)
        {
            foreach (string line in input)
            {
                string[] splitLine = line.Split(" ");//move,1,from,3,to,2
                int itemAmount = int.Parse(splitLine[1]);
                int sourceColumn = int.Parse(splitLine[3]);
                int destinationColumn = int.Parse(splitLine[5]);

                for (int i = 0; i < itemAmount; i++)
                {
                    stackList[destinationColumn - 1].Push(stackList[sourceColumn - 1].Pop());
                }

            }
            TopSeparateCrates = string.Join("", stackList.Select(x => x.Peek()));
        }

        public void MoveCratesTogether(string[] input, List<Stack<char>> copyStackList)
        {
            
            foreach(string line in input)
            {
                string[] splitLine = line.Split(" ");//move,1,from,3,to,2
                int itemAmount = int.Parse(splitLine[1]);
                int sourceColumn = int.Parse(splitLine[3]);
                int destinationColumn = int.Parse(splitLine[5]);

                var tempStack = new Stack<char>();
                for (int j = 0; j < itemAmount; j++)
                {
                    tempStack.Push(copyStackList[sourceColumn -1].Pop());
                }
                while(tempStack.Count > 0)
                {
                    copyStackList[(destinationColumn -1)].Push(tempStack.Pop());
                }
            }
            TopTogetherCrates = string.Join("", copyStackList.Select(x => x.Peek()));

        }
    }
}
