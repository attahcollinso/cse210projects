Public class EternalGoal : Goal
{
    Public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    Public override void RecordEvent()
    {
        // Code to record event
    }

    Public override bool IsComplete()
    {
        Return false;
    }

    Public override string GetStringRepresentation()
    {
        Return $”E,{_shortName},{_description},{_points}”;
    }
}

