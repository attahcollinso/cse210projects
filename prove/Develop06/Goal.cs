public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _points = points;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}