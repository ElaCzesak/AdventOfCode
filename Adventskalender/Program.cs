using System;
using System.IO;

namespace Calories
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] strNumbers = System.IO.File.ReadAllLines(@"C:\Build_Informed\puzzel.txt");
            int count = 0;
            foreach (string strNumber in strNumbers)
            {
                if (Int32.TryParse(strNumber, out int number))
                {
                    count = count + number;
                }
            }

            Console.WriteLine("Total : " + count);

        }





        /* COUNT SUM 
            string[] strNumbers = System.IO.File.ReadAllLines(@"C:\Build_Informed\puzzel.txt");
            int count = 0;
            foreach (string strNumber in strNumbers)
            {
                if (Int32.TryParse(strNumber, out int number))
                {
                    count = count + number;
                }
            }

            Console.WriteLine("Total : " + count);
        */

        /* FIRST SOLUTION
        int elf1Calories = 6529 + 8085 + 4534;
        int elf2Calories = 1503;
        int elf3Calories = 2983 + 5030;            
        int elf4Calories = 2135 + 5866 + 5092;
        int elf5Calories = 5059;

        int highestCalories = Math.Max(elf1Calories, Math.Max(elf2Calories, Math.Max(elf3Calories, Math.Max(elf4Calories, elf5Calories))));

        Console.WriteLine("The Elf carrying the most Calories is the fourth Elf, carrying a total of " + highestCalories + " Calories.");*/

    }
}

