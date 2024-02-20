public class Biking : Activity {
    public Biking (string date, int duration) : base(date, duration){}

    public void SetDistance(double distance) {
        _distance = distance;
    }

    public override string GetSummary() {
        string summary = @$"{_date} Biking ({_duration} min) - Distance {GetDistance():F1} km, 
        Speed {GetSpeed():F1} km/h, Pace: {GetPace():F2} min per kilometer";
        return summary;
    }
}

// 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile