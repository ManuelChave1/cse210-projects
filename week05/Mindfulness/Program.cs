using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathActivity = new BreathingActivity();
        ReflectingActivity refletionActivity = new ReflectingActivity();
        ListingActivity listiningActivity = new ListingActivity(); 
        
        int choice;
        do
        {
            Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflecting activity\n3. Start listing activity\n4. Quit ");
            Console.Write("Select a choice from a menu: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    breathActivity.Run();
                    break;
                case 2:
                    Console.Clear();
                    refletionActivity.Run();
                    break;
                case 3:
                    listiningActivity.Run();
                    break;
                default:
                    Console.WriteLine("ERROR!!");
                    break;
            }
        } while (choice != 4);

    }
}