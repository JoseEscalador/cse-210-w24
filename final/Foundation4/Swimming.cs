public class Swimming : Activity {
    private int _laps;

    public Swimming (string date, int duration, int laps) : base(date, duration){
        _laps = laps;
    }

    public override double GetDistance() {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed() {
        double distance = _laps * 50 / 1000;
        return (distance/_duration) * 60 ;
    }

    public override double GetPace() {
        double distance = _laps * 50 / 1000;
        return _duration/distance;
    }

    public override string GetSummary() {
        string summary = @$"{_date} Swimming ({_duration} min) - Distance {GetDistance():F1} km, 
        Speed {GetSpeed():F1} km/h, Pace: {GetPace():F2} min per kilometer";
        return summary;
    }
}