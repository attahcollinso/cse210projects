public abstract class Activity 
{
    protected DateTime _activityDate;
    protected double _activityLength;

    public Activity(DateTime activityDate, double activityLength) 
    {
        _activityDate = activityDate;
        _activityLength = activityLength;
    }

    public abstract double GetDistanceKm();
    public abstract double GetSpeedKmph();

    public double GetDistanceMiles() 
    {
        return GetDistanceKm() * 0.62;
    }

    public double GetSpeedMph() 
    {
        return GetSpeedKmph() * 0.62;
    }

    public double GetPaceMinPerKm() 
    {
        return _activityLength / GetDistanceKm();
    }

    public double GetPaceMinPerMile() 
    {
        return _activityLength / GetDistanceMiles();
    }

    public virtual string GetSummary() 
    {
        return $"{_activityDate:dd MMM yyyy} {GetType().Name} ({_activityLength} min) - Distance: {GetDistanceKm()} km / {GetDistanceMiles():0.00} miles, Speed: {GetSpeedKmph()} kph / {GetSpeedMph():0.00} mph, Pace: {GetPaceMinPerKm():0.00} min per km / {GetPaceMinPerMile():0.00} min per mile";
    }
}