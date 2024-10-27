
Public abstract class Goal
{
    Protected string _shortName;
    Protected string _description;
    Public string _points;

    Public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _points = points;
        _description = description;
    }

    Public abstract void RecordEvent();
    Public abstract bool IsComplete();
    Public abstract string GetStringRepresentation();

    Public virtual string GetDetailsString()
    {
        If (IsComplete())
        {
            Return $”[X] {_shortName} ({_description})”;
        }
        Else
        {
            Return $”[ ] {_shortName} ({_description})”;
        }
    }
}
