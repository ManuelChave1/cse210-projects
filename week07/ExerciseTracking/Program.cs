using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2025, 06, 17), 30, 5), 
            new Cycling(new DateTime(2025, 06, 18), 30, 20), 
            new Swimming(new DateTime(2025, 06, 19), 30, 20) 
        };

           
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

    }
}