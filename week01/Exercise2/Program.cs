using System;
// Add  strech chalenge to this assignment later, not accept values grater than 100 or less than 0
// Add logic to print letter with equivalent sign +/- eg: (A- not A+, B+,B- or B just F not F+ or F-)
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = " ";

        if(percentage>=90)
        {
            letter = "A";
        }
        else if(percentage>= 80)
        {
            letter = "B";
        }
        else if(percentage >=70)
        {
            letter = "C";
        }
        else if(percentage >= 60)
        {
            letter = "D";
        }
        else if(percentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.Write(" Erro, invalide enter");
        }
       Console.Write($"Your grade letter is: {letter}");
    }
}