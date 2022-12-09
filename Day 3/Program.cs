// See https://aka.ms/new-console-template for more information
using Day_3;

string[] lines = File.ReadAllLines(@"D:\Projects\AdventOfCode2022\Day 3\ListOfContents.txt");

var lineCount = lines.Count();
Rucksack firstRucksack = new Rucksack();


foreach (string row in lines)
{
    var (firstHalf, secondHalf) = firstRucksack.GetHalves(row);

    char[] firstHalfArray = firstHalf.ToCharArray();
    char[] secondHalfArray = secondHalf.ToCharArray();

    IEnumerable<char> intersectingItems = firstHalfArray.Intersect(secondHalfArray);
    firstRucksack.GetPriority(intersectingItems);

    firstRucksack.TotalFirstSum += firstRucksack.PartialSum;
};

Console.WriteLine("The sum of properties of those item types is {0}", firstRucksack.TotalFirstSum);

Rucksack secondRucksack = new Rucksack();
for (int i = 0; i < lineCount; i += 3)
{
    string firstLine = lines[i];
    string secondLine = lines[i + 1];
    string thirdLine = lines[i + 2];

    HashSet<char> firstSet = new HashSet<char>(firstLine);
    HashSet<char> secondSet = new HashSet<char>(secondLine);
    HashSet<char> thirdSet = new HashSet<char>(thirdLine);

    HashSet<char> commonSet = new HashSet<char>(firstSet.Intersect(secondSet));
    HashSet<char> finalSet = new HashSet<char>(commonSet.Intersect(thirdSet));

    secondRucksack.GetPriority(finalSet);

    secondRucksack.TotalSecondSum += secondRucksack.PartialSum;

}

Console.WriteLine("The sum of properties of those item types is {0}", secondRucksack.TotalSecondSum);



