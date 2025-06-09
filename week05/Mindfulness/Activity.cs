public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = " ";
        _description = " ";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + " Activity\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session:  ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed onother {_duration} seconds of the {_name} Activity");
        ShowSpinner(4);
        Console.Clear();
    }


    public void ShowSpinner(int second)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(second);

        while (DateTime.Now < futureTime)
        {
            //Thread.Sleep(1000);
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write(@"|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write(@"/");
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine(" ");

    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            if (i == 1)
            {
                Console.Write(" ");
            }
        }
    }
}