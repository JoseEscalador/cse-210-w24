public class Running : Activity {
    public Running (string date, int duration) : base(date, duration){}

    public void SetDistance(double distance) {
        _distance = distance;
    }
    public override string GetSummary() {
        string summary = @$"{_date} Running ({_duration} min) - Distance {GetDistance():F1} km, 
        Speed {GetSpeed():F1} km/h, Pace: {GetPace():F2} min per kilometer";
        return summary;
    }
}