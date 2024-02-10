public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal (string name, string description, string points, int target,
    int bonus) : base(name, description, points) {
        _target = target;
        _bonus = bonus;    
    }
    public override void RecordEvent() {
        _amountCompleted = _amountCompleted + 1;
        IsComplete();
    }
    public override bool IsComplete() {
        if (_amountCompleted == _target) {
            return true;
        }
        else {
            return false;
        }
    }
    //keeping here just in casev
    // public int GetBonus() {
    //     return _bonus;
    // }
    public override string GetDetailsString() {
        if (IsComplete()) {
            return $"[X] {_name} {_description} --- Currently completed: {_amountCompleted}/{_target}";    
        }
        else {
            return $"[ ] {_name} {_description} --- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation() {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}