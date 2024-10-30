public class Swimming : Activity 
{
    private int _swimmingLaps;

    public Swimming(DateTime activityDate, double activityLength, int swimmingLaps): base(activityDate, activityLength) 
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double GetDistanceKm() 
    {
        return (double)_swimmingLaps * 50 / 1000;
    }

    public override double GetSpeedKmph()
    {
        return (GetDistanceKm() / _activityLength) * 60;
    }
}
