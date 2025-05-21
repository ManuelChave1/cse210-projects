using System;


class Program
{
    static void Main(string[] args)
    {
   
        int choice;
        string fileName;

        void DisplayMenu()
        {
            Entry entry = new Entry();
            Console.WriteLine("Welcome to the Journal Program!");
            do
            {

                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1: Write\n2: Display\n3: Load\n4: Save\n5: Quit");
                Console.Write("What would you like to do? ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        entry.AddEntry();
                        break;
                    case 2:
                        entry.Display();
                        break;
                    case 3:
                        Console.WriteLine("What is the FileName: ");
                        fileName = Console.ReadLine();
                        entry.LoadFromAFile(fileName);

                        break;   
                    case 4:
                        Console.WriteLine("What is the Filename? ");
                        fileName = Console.ReadLine();
                        entry.SaveToAFile(fileName);
                        break;
                    case 5:
                        Console.WriteLine("Thanks to join the program");
                        break;    
                    default:
                        break;
                }
                           
            } while (choice != 5);
  
        }
        DisplayMenu();
        
    }
}