using System;

class Program
{
    static void Main(string[] args)
    {

      int guess;      
       Random randomNumber = new Random();   
       string response;
       
    do{ 

       int magicNumber =  randomNumber.Next(0,101);
       int iterator = 0;
            do{

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(guess ==  magicNumber)
            {
                Console.WriteLine("Congratulations, you guessed it!!!");
            }

            iterator++;

            }while(guess != magicNumber);

        Console.WriteLine($"You have made it with {iterator} guesses");
        Console.WriteLine("Do you want to continue (y/n)" );
        response= Console.ReadLine();
          
    }while(response != "n");
    
    }
  }
