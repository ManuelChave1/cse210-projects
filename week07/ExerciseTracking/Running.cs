class Running: Activity
{
    private double _distance; 

    
    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }


    public override double GetDistance()  
    {
       return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60; 
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetDuration()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}

