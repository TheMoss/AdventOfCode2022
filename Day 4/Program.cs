// See https://aka.ms/new-console-template for more information
using Day_4;

string filepath = @"D:\Projects\AdventOfCode2022\Day 4\cleaningPairs.txt";


Cleaning cleaning = new Cleaning();

cleaning.ParseFile(filepath);
cleaning.GetFullOverlap();
cleaning.GetPartialOverlap();
Console.WriteLine(cleaning.CountFullyOverlapped);
Console.WriteLine(cleaning.CountPartiallyOverlapped);