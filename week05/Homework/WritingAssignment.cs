public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return "Tile: " + _title + " by " + base._studentName;
    }
}
