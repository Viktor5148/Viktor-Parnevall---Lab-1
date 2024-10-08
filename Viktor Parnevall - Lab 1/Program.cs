using System;

class Program
{
    static void Main()
    {
        string input = "29535123p48723487597645723645";
        long totalSum = 0;


        for (int i = 0; i < input.Length; i++)
        {

            for (int j = i + 1; j <= input.Length; j++)
            {

                string substring = input.Substring(i, j - i);


                if (long.TryParse(substring, out long number))
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(substring + " (Korrekt)");
                    totalSum += number;
                }
                else
                {

                    Console.ResetColor();
                    Console.WriteLine(substring + " (Ej korrekt)");
                }
            }
        }


        Console.ResetColor();
        Console.WriteLine("\nTotal summa av alla delsträngar som kan omvandlas till tal: " + totalSum);
    }
}
