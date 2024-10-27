Public class ChecklistGoal : Goal
{
    Private int _amountCompleted;
    Private int _target;
    Private int _bonus;
    
    Public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName,
        Description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    Public override void RecordEvent()
    {
        _amountCompleted++;
    }

    Public override bool IsComplete()
    {
        Return _amountCompleted >= _target;
    }

    Public override string GetStringRepresentation()
    {
        Return $”C,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}”;
    }

    Public override string GetDetailsString()
    {
        If (IsComplete())
        {
            Return $”[X] {_shortName} ({_description}) – currently complete {_amountCompleted}/{_target}”;
        }
        Else
        {
            Return $”[ ] {_shortName} ({_description}) – currently complete {_amountCompleted}/{_target}”;
        };
    }
    
}
