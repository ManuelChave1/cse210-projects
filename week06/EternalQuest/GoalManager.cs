class GoalManager
{
    private List<Goal> _goal = new List<Goal>();
    private int _score;


    public GoalManager()
    {

    }

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the Menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:

                    DisplayPlayerInfo();

                    break;

                case 3:

                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;

                case 6:

                    break;

                default:

                    break;

            }
        } while (choice != 6);


    }

    public void DisplayPlayerInfo()
    {
        int goalNumber = 1;
        Console.WriteLine("The goals are:");
        foreach (var goal in _goal)
        {
            Console.WriteLine($"{goalNumber++}. {goal.GetStringRepresentation()}");
        }
    }

    public void ListGoalNames()
    {
        int goalNumber = 1;
        Console.WriteLine("The goals are:");
        foreach (var goal in _goal)
        {
            Console.WriteLine($"{goalNumber++}. {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (var goal in _goal)
        {
            Console.WriteLine($"- {goal.GetDescription()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int choice = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case 1:
                Console.Write("What is the name of you goal: ");
                string name = Console.ReadLine();
                Console.Write("What is are short description of it: ");
                string description = Console.ReadLine();
                Console.Write("What is the amout of points associented with this goal: ");
                string points = Console.ReadLine();
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                Console.Write("What is the name of you goal: ");
                name = Console.ReadLine();
                Console.Write("What is are short description of it: ");
                description = Console.ReadLine();
                Console.Write("What is the amout of points associented with this goal: ");
                points = Console.ReadLine();
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("What is the name of you goal: ");
                name = Console.ReadLine();
                Console.Write("What is are short description of it: ");
                description = Console.ReadLine();
                Console.Write("What is the amout of points associented with this goal: ");
                points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accompleshed for a bonus: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accompleshing it that many times: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("ERROR.");
                return;
        }

        _goal.Add(newGoal);


    }
    public void RecordEvent()
    {

        ListGoalNames();

        Console.Write("Which goal did you accomplish: ");
        int goalAccomplished = int.Parse(Console.ReadLine());
        int goalIndex = goalAccomplished - 1;


        if (goalIndex >= 0 && goalIndex <= _goal.Count)
        {
            Console.WriteLine($"Congratulation you have earned {_goal[goalIndex].GetPoints()} points");

            _score += int.Parse(_goal[goalIndex].GetPoints());
            Console.WriteLine($"You now have {_score} points");

            _goal[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("ERROR!");
        }
    }
    
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"{_score} \n");

            foreach (var goal in _goal)


                    if (goal is SimpleGoal simple)
                {
                    writer.WriteLine($"SimpleGoal:{simple.GetShortName()},{simple.GetDescription()},{simple.GetPoints()},{simple.IsComplete()}");
                }
                else if (goal is EternalGoal eternal)
                {
                    writer.WriteLine($"EternalGoal:{eternal.GetShortName()},{eternal.GetDescription()},{eternal.GetPoints()}");
                }
                else if (goal is ChecklistGoal checklist)
                {
                    writer.WriteLine($"ChecklistGoal:{checklist.GetShortName()},{checklist.GetDescription()},{checklist.GetPoints()},{checklist.GetAmountCompleted()},{checklist.GetTarget()},{checklist.GetBonus()}");
                }
                
            }
        }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            _goal.Clear(); 

            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0].Trim());
            }

            for (int i = 2; i < lines.Length; i++)
            {
                
                string[] parts = lines[i].Split(':');
                string goalType = parts[0].Trim();
                string[] values = parts[1].Split(',');

                switch (goalType)
                {
                    case "SimpleGoal":
                        string sName = values[0];
                        string sDescription = values[1];
                        string sPoints = values[2];
                        bool sComplete = bool.Parse(values[3]);
                        var simpleGoal = new SimpleGoal(sName, sDescription, sPoints);
                        if (sComplete) simpleGoal.RecordEvent(); 
                        _goal.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        string eName = values[0];
                        string eDescription = values[1];
                        string ePoints = values[2];
                        _goal.Add(new EternalGoal(eName, eDescription, ePoints));
                        break;

                    case "ChecklistGoal":
                        string cName = values[0];
                        string cDescription = values[1];
                        string cPoints = values[2];
                        int cCompleted = int.Parse(values[3]);
                        int cTarget = int.Parse(values[4]);
                        int cBonus = int.Parse(values[5]);
                        var checklistGoal = new ChecklistGoal(cName, cDescription, cPoints, cTarget, cBonus);

                        
                        for (int index = 0; i < cCompleted; index++)
                            checklistGoal.RecordEvent();

                        _goal.Add(checklistGoal);
                        break;
                }
            }

    
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}


