public class Activity {
    protected string _date;
    protected int _duration;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity (string date, int duration) {
        _date = date;
        _duration = duration;
    }
    
    public virtual double GetDistance() {
        return _distance;
    }

    public virtual double GetSpeed() {
        return (_distance/_duration) * 60 ;
    }

    public virtual double GetPace() {
        return _duration/_distance;
    }

    public virtual string GetSummary() {
        return "";
    }

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
}