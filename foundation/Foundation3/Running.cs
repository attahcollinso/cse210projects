public class Running : Activity 
{
    private double _distance; 

    public Running(DateTime activityDate, double activityLength, double distance): base(activityDate, activityLength) 
    {
        _distance = distance;
    }

    public override double GetDistanceKm()
    {
        return _distance;
    }

    public override double GetSpeedKmph() 
    {
        return (GetDistanceKm() / _activityLength) * 60;
    }
}
