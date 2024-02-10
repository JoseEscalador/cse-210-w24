using System.Dynamic;
using System.Diagnostics;

public class GoalManager {
    private List<Goal> _goals;
    private int _score;

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddScore(int num) {
        _score =+ num;
    }

    public void Start() {
        string choice = "0";
        //_goals = new List<Goal>();
        while (choice != "6") {

            Console.WriteLine($"\nYou have {_score} points.");

            Console.WriteLine("\nMenu Options:\n");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1") {
                Console.Clear();
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple goal");
                Console.WriteLine("  2. Eternal goal");
                Console.WriteLine("  3. Checklist goal");
                Console.Write("\nWhich type of goal would you like to create? ");
                string type = Console.ReadLine();
                CreateGoals(type);
            }

            else if (choice == "2") {
                ListGoalDetails();
            }
            else if (choice == "3") {
                SaveGoals();
            }
            else if (choice == "4") {
                LoadGoals();
            }
            else if (choice == "5") {
                RecordEvent();
            }
            else if (choice != "6") {
                Console.Write("Not valid, try again: ");
            }
        }
    }
    public void DisplayPlayerInfo() {

    }

    public void ListGoalNames() {
        Console.WriteLine();
        int i = 0;
        foreach (Goal goal in _goals) {
            i++;
            string [] args = goal.GetStringRepresentation().Split(",");
            string name = args[1];
            Console.WriteLine($"{i}. {name}");
        }
    }

    public void ListGoalDetails() {

        Console.WriteLine();
        int i = 0;
        foreach (Goal goal in _goals) {
            i++;
            string details = goal.GetDetailsString();
            Console.WriteLine($"{i}. {details}");
        }
    }
    public void CreateGoals(string type) {
        if (type == "1") {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            SimpleGoal newSimple = new SimpleGoal(name, description, points);
            _goals.Add(newSimple);
            
        }
        else if (type == "2") {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            EternalGoal newEternal = new EternalGoal(name, description, points);
            _goals.Add(newEternal);
        }
        else if (type == "3") {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newCL = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newCL);
        }
        
    }
    public void RecordEvent() {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine())-1;
        if (_goals[index].IsComplete()) {
            Console.WriteLine("Sorry but this goal is already completed and we will bring you back to the main menu.");
        }
        else {
            _goals[index].RecordEvent();
            string [] args = _goals[index].GetStringRepresentation().Split(",");
            int pointsEarned = 0;
            if (args[0] == "ChecklistGoal") {
                if (args[5] == args[6]) 
                {
                    pointsEarned = int.Parse(args[3]) + int.Parse(args[4]);
                    _score = _score + pointsEarned;
                }
                else {
                    pointsEarned = int.Parse(args[3]);
                _score = _score + pointsEarned;
                }
            }
            else {
                pointsEarned = int.Parse(args[3]);
                _score = _score + pointsEarned;
            }
            Console.WriteLine($"\nCongratulations you have earned {pointsEarned}!");
        }
    }
    public void SaveGoals() {
        Console.WriteLine("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals) {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals() {
        int count = 0;
        Console.WriteLine("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        
        {
            if(count == 0) {
                _score = int.Parse(line);
            }   
            count++;
            string [] args = line.Split(",");
            if (args[0] == "SimpleGoal") {
                string name = args[1];
                string description = args[2];
                string points = args[3];
                Goal newSimple2 = new SimpleGoal(name, description, points);
                if (args[4] == "True") {
                    newSimple2.RecordEvent();
                }
                _goals.Add(newSimple2);
            }
            else if (args[0] == "EternalGoal") {
                string name = args[1];
                string description = args[2];
                string points = args[3];
                Goal newEternal2 = new EternalGoal(name, description, points);
                _goals.Add(newEternal2);
            }
            else if (args[0] == "ChecklistGoal") {
                string name = args[1];
                string description = args[2];
                string points = args[3];
                int bonus = int.Parse(args[4]);
                int target = int.Parse(args[5]);
                int amountCompleted = int.Parse(args[6]);
                Goal newCL2 = new ChecklistGoal(name, description, points, target, bonus);
                int i = 0;
                while (i < amountCompleted) {
                    newCL2.RecordEvent();
                }
                _goals.Add(newCL2);
            }        
        }
    }
}