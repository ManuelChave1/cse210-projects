abstract class  Activity
{
    
    private DateTime _date;
    private double _duration; 

    
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public double GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} - {this.GetType().Name} ({GetDuration()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}


