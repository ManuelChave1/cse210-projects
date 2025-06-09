using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assign = new Assignment("Samuel Bennet","Multiplication");
        MathAssignment mathassign = new MathAssignment("Roberto rodriguez", "Fractions", "7.9","8-19");
        WritingAssignment WritingAssign = new WritingAssignment("Mary Waters", "European History", "The causes of word war II");

     
        Console.WriteLine(assign.GetSummary());
        Console.WriteLine("\n"+ mathassign.GetSummary()); 
        Console.WriteLine(mathassign.GetHomeWorkList()); 
        Console.WriteLine("\n" + WritingAssign.GetSummary());
        Console.WriteLine(WritingAssign.GetWritingInformation());

    }
}