public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
   };
  private List<string> _questions = new List<string>
  {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
  };

  private Random random =  new  Random();

  public ReflectingActivity() 
  {
      base._name = "Reflection";
      base._description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

  }

 public void Run()
  {
      base.DisplayStartingMessage();
      base._duration = int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Get ready...");
      base.ShowSpinner(5);
      Console.WriteLine("Consider the following prompt: \n");
      DisplayPrompt();
      Console.WriteLine("\nWhen you have something in mind press enter to continue.");
      Console.ReadKey();
      Console.WriteLine("\nNow ponder on each of the following question as they related to this experience.\n");
      Console.Write("You may begin in:  ");
      base.ShowCountDown(7);
      Console.Clear();
      DateTime correnteDate = DateTime.Now;
      DateTime futureTime = correnteDate.AddSeconds(_duration);

      while(DateTime.Now < futureTime)
      {
          DisplayQuestion();
      }

      base.DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
      int indexPrompt = random.Next(_prompts.Count);
      string randomPrompt = _prompts.ElementAt(indexPrompt);
      return randomPrompt;
  }

 public string GetRandomQuestion()
  {
      int indexQuestion = random.Next(_questions.Count);
      string randomQuestion = _questions.ElementAt(indexQuestion);
      return randomQuestion;
  }

 public void DisplayPrompt()
 {
     Console.WriteLine($"---  {GetRandomPrompt()}  ---") ;
  }

  public void DisplayQuestion()
  {
      Console.Write($"> {GetRandomQuestion()}  ");
      base.ShowSpinner(8);
  }
}