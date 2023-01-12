using System;
using System.IO;

// Advent of code
var strNumbers = File.ReadAllLines(@"C:\Build_Informed\puzzel.txt");

var max = 0;
var sum = 0;

foreach (var strNumber in strNumbers)
{
    if (Int32.TryParse(strNumber, out int number))
    {
        sum = sum + number;
    }
    if (strNumber == "")
    {
        Console.WriteLine("Total elf calories : " + sum);

        max = Math.Max(max, sum);
        sum = 0;
    }
}
Console.WriteLine("Max elf calories : " + max);
