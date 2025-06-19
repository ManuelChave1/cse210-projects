    abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected string _points;

        public Goal(string name, string description, string point)
        {
            _shortName = name;
            _description = description;
            _points = point;
        }

        public string GetShortName()
        {
            return _shortName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetPoints()
        {
            return _points;
        }

        public abstract void RecordEvent();
      
        public abstract bool IsComplete();
        public virtual string GetDetailsString()
        {
            return " ";
        }
        public abstract string GetStringRepresentation();
    }

