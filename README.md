# Advent of Code 2022

[Advent of Code](https://adventofcode.com/about) is an event that takes place from 1st to 25th December. Each day a new puzzle is revealed and the participants can test their problem solving skills utilizing any programming language. I chose C#.
## Day 1

[Advent of Code - Day 1](https://adventofcode.com/2022/day/1)

### Part 1
To find out which elf of a given group is carrying the most calories, first all of the lines from the input file are converted from type `string` to type `int` and added to a list `CaloriesPerElf`. Then the list is sorted, after that the list's order is reversed so the first position of the list is the highest number of calories an elf is carrying.
### Part 2
The task is to determine the top three Elves carrying the most calories and the sum of their provisions. Since the calorie list is already sorted in the descending order, all that's left is to sum the first three positions to get the answer.

## Day 2

[Advent of Code - Day 2](https://adventofcode.com/2022/day/2)

### Part 1
I chose to write down all possible combinations of moves and calculate how many points would be given for each one. This forms a dictionary, where a combination is the key and score is the value. The moves are extracted from the input file and used to find the corresponding player score. The final score from this strategy is the sum of scores for each move.
### Part 2
Another dictionary is made to provide scores for the second strategy. Again, the scores are summed up to get the final one.

## Day 3
[Advent of Code - Day 3](https://adventofcode.com/2022/day/3)
### Part 1
A rucksack's content is split to two equally sized arrays. The method `Intersect()` is used to get the letter that occurs in both of them. Since the priorities `a-z` and `A-Z` are sorted, it's possible to use ASCII decimal code values for the characters. 

In ASCII the letter `a` has a decimal value of 97, `A` has 65. The task's values start at `1` for lowercase and `27` for uppercase characters. To account for this difference, if the character is lowercase, it has to have `96` substracted from its ASCII decimal value, if it's uppercase - `38`.

The sum of the priorities is obtained by summing up the partial scores from each of the rucksacks.
### Part 2
This time, the rucksacks are grouped by 3 at a time. Due to the `HashSet<T>`'s properties, each set won't have any duplicating characters. Intersecting the first set with the second, and then the second with the third, the resulting set will contain only the unique character. That's going to be the score for a given group of rucksacks.

Just as in the first part, the answer to the puzzle is a sum of all of the partial priorities.
