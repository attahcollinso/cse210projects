
Public class SimpleGoal : Goal
{
    Private bool _isComplete;
    Public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    Public override void RecordEvent()
    {
        _isComplete = true;
    }
    Public override bool IsComplete()
    {
        Return _isComplete;
    }
    Public override string GetStringRepresentation()
    {
        Return $”S,{_shortName},{_description},{_points},{_isComplete}”;
    }
}

