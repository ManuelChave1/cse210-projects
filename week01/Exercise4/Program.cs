using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>ListOfNumbers = new List<int>();
        int entrense;
        int smallerPositiveNumber = 0;

        Console.WriteLine("Enter a Liste of numbers, enter 0(Zero) when finish\n");
       

        do{
        Console.Write("Enter a number: ");
        entrense = int.Parse(Console.ReadLine());
         if(entrense == 0)
          {
            continue;
          }
         
        ListOfNumbers.Add(entrense);
        }while(entrense !=0);

        int sum = ListOfNumbers.Sum();
        double average = ListOfNumbers.Average();
        int largestNumber = ListOfNumbers.Max();

        List<int>positiveNumber = new List<int>();
        foreach (var item in ListOfNumbers)
        {
             if (item > 0)
          {
            positiveNumber.Add(item);
            smallerPositiveNumber = positiveNumber.Min();
          }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallerPositiveNumber}");
         ListOfNumbers.Sort();
         foreach (var item in ListOfNumbers)
        {
            Console.WriteLine(item);
        }
    }
}