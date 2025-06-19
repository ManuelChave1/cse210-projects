class Cycling:Activity
{
    private double _speed;

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }

    
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetDuration()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}

