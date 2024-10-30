public class Cycling : Activity 
{
    private double _speed; 

    public Cycling(DateTime activityDate, double activityLength, double speed): base(activityDate, activityLength) 
    {
        _speed = speed;
    }

    public override double GetSpeedKmph() 
    {
        return _speed;
    }

    public override double GetDistanceKm() 
    {
        return (_speed / 60) * _activityLength;
    }
}