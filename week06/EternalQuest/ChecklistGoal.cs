class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    

    
    public override void RecordEvent()
    {
        if(_amountCompleted < _target)
        {
            _amountCompleted ++;

            if(_amountCompleted == _target)
            {
                int points = int.Parse(base._points);

                int finalPoint =   points + _bonus;
                base._points = finalPoint.ToString();
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target; ;
    }
    public override string GetDetailsString()
    {
        return " ";
    }

    public override string GetStringRepresentation()
    {
        string formattedString;
        if (IsComplete())
        {
            formattedString = "[ X ]  " + base._shortName + "(" + base._description + ")";
        }
        else
        { 
            formattedString = "[   ]  " + base._shortName + "(" + base._description + ")" + " --- " + "Currently completed " + _amountCompleted + " / " + _target;
        }

        return formattedString;
        
    }
}

