public abstract class Goal {
    protected string _name;
    protected string _description;
    protected string _points;

    public Goal (string name, string description, string points) {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() {
        return _name;
    }
    //keeping here just in case
    // public string GetPoints() {
    //     return _points;
    // }

    public abstract void RecordEvent();

    public virtual bool IsComplete() {
        return false;
    }
    public virtual string GetDetailsString() {
        if (IsComplete() == true) {
            return $"[X] {_name} {_description}";    
        }
        else {
            return $"[ ] {_name} {_description}";
        }
    }
    
    public abstract string GetStringRepresentation();
}