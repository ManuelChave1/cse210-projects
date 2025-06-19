    class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, double duration, int laps): base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50) / 1000;
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
            return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetDuration()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per km";
        }
    }

