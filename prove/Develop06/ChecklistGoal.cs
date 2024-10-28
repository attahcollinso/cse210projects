public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName,
        description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"C,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) - currently complete {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) - currently complete {_amountCompleted}/{_target}";
        };
    }
    
}