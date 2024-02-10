using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal (string name, string description, string points) : base(name, description, points) {
        _isComplete = false;
    }

    public override void RecordEvent() {
        _isComplete = true;
    }
    public override bool IsComplete() {
        if (_isComplete == true) {
            return true;
        }
        else {
            return false;
        }

    }
    public override string GetStringRepresentation() {
        string completed = IsComplete().ToString();
        return $"SimpleGoal,{_name},{_description},{_points},{completed}";
    }


}