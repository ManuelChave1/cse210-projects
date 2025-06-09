public class BreathingActivity : Activity
{
    public BreathingActivity() //: base(name, description, duration)
    {
      base._name = "Breathing";
      base._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }

    public void Run()
    {
      base.DisplayStartingMessage();
      base._duration = int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Get ready...");
      base.ShowSpinner(3);
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(base._duration);
      while(DateTime.Now < futureTime)
      {
        Console.Write("Breathe in..."); 
        base.ShowCountDown(4);
        Console.Write("\nNow breathe out..."); 
        base.ShowCountDown(6);
        Console.WriteLine("\n" );

      }
     base.DisplayEndingMessage();
     Console.Clear();
    }
}