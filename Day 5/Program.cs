using Day_5;
using Microsoft.Win32.SafeHandles;

string[] input = File.ReadAllLines(@"D:\Projects\AdventOfCode2022\Day 5\CraneData.txt");
var originalStackList = new List<Stack<char>>()
{
    new Stack<char>(new[] { 'G', 'T', 'R', 'W' }),
    new Stack<char>(new[] { 'G', 'C', 'H', 'P', 'M', 'S', 'V', 'W' }),
    new Stack<char>(new[] { 'C', 'L', 'T', 'S', 'G', 'M' }),
    new Stack<char>(new[] { 'J', 'H', 'D', 'M', 'W', 'R', 'F' }),
    new Stack<char>(new[] { 'P', 'Q', 'L', 'H', 'S', 'W', 'F', 'J' }),
    new Stack<char>(new[] { 'P', 'J', 'D', 'N', 'F', 'M', 'S' }),
    new Stack<char>(new[] { 'Z', 'B', 'D', 'F', 'G', 'C', 'S', 'J' }),
    new Stack<char>(new[] { 'R', 'T', 'B' }),
    new Stack<char>(new[] { 'H', 'N', 'W', 'L', 'C' }),
};

var copyStackList = new List<Stack<char>>()
{
    new Stack<char>(new[] { 'G', 'T', 'R', 'W' }),
    new Stack<char>(new[] { 'G', 'C', 'H', 'P', 'M', 'S', 'V', 'W' }),
    new Stack<char>(new[] { 'C', 'L', 'T', 'S', 'G', 'M' }),
    new Stack<char>(new[] { 'J', 'H', 'D', 'M', 'W', 'R', 'F' }),
    new Stack<char>(new[] { 'P', 'Q', 'L', 'H', 'S', 'W', 'F', 'J' }),
    new Stack<char>(new[] { 'P', 'J', 'D', 'N', 'F', 'M', 'S' }),
    new Stack<char>(new[] { 'Z', 'B', 'D', 'F', 'G', 'C', 'S', 'J' }),
    new Stack<char>(new[] { 'R', 'T', 'B' }),
    new Stack<char>(new[] { 'H', 'N', 'W', 'L', 'C' }),

};

ExpeditionColumns expedition = new ExpeditionColumns();

expedition.MoveCratesSeparately(input, originalStackList);
expedition.MoveCratesTogether(input, copyStackList);


Console.WriteLine(@"Crates on top of the stacks when moved one by one:{0}", expedition.TopSeparateCrates);
Console.WriteLine(@"Crates on top of the stacks when moved together:{0}", expedition.TopTogetherCrates);