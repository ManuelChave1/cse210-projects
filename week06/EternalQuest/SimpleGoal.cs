class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points): base(name, description, points)
    {
        _isComplete = false;
    }





    public override void RecordEvent()
    {
        
        if(_isComplete == false)
        {
            IsComplete();
        }         
    }

    public override bool IsComplete()
    {
        return _isComplete = true ;
    }

    public override string GetStringRepresentation()
    {
        string formattedString;
        if(_isComplete)
        {
            formattedString = "[ X ]  " + base._shortName + "(" + base._description + ")";
        }
        else
        {
            formattedString = "[   ]  " + base._shortName + "(" + base._description + ")" ;
        }

            return formattedString;
    }
}

