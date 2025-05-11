using System;

class Program
{
    static void DisplayWelcome()
    {
       Console.WriteLine("Welcome to the Program");
    }

     static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name =  Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber =  int.Parse(Console.ReadLine());
        return favNumber;

    }

    static int SquareNumber(int num)
    {
        int squareNum  = num * num;
        return squareNum;
    }

    static void DisplayResult ()
    {
        string username =  PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        Console.WriteLine($"{username}, The square of your number is: {squareNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}