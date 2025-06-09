public class ListingActivity : Activity
{
        private int _count;
        private List<string> _prompts = new List<string>
        {
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "When have you felt the Holy Ghost this month?",
           "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            base._name = "Listining";
            base._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        }

        public void Run()
        {
            base.DisplayStartingMessage();
            base._duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get Read...");
            base.ShowSpinner(4);
            Console.WriteLine("List as many responces you can to the following prompts: ");
            GetRandomPrompt();
            Console.Write("You may begin in: ");
            base.ShowCountDown(6);
            Console.WriteLine();
            DateTime correnteDate = DateTime.Now;
            DateTime futureTime = correnteDate.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                Console.Write("> ");
                string responses = Console.ReadLine();
                GetListFromUser(responses);
                _count++;

            }

            Console.WriteLine($"You listet {_count} items");

            base.DisplayEndingMessage();



        }
        public void GetRandomPrompt()
        {
            Random random = new Random();
            int indexPrompt = random.Next(_prompts.Count);
            string randomPrompt = _prompts.ElementAt(indexPrompt);
            Console.WriteLine($"---  {randomPrompt}  ---");  
        }

        public List<string> GetListFromUser(string responses)
        {
            List<string> userImput = new List<string>();
            userImput.Add(responses);
          //  _count = userImput.Count;
            return userImput;
        }
} 