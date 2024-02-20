using System;

class Program
{
    static void Main(string[] args)
    {
        //Space reserved for 
        //Populating the activity classes.
        string date1 = "10 DEZ 2023";
        string date2 = "15 DEZ 2023";
        string date3 = "05 JAN 2024";

        int duration1 = 50;
        int duration2 = 40;
        int duration3 = 25;

        double distancekm1 = 4.1;
        double distancekm3 = 8.6;
        int laps2 = 50;

        Running newRunning = new Running(date1, duration1);
        Swimming newSwimming = new Swimming(date2, duration2, laps2);
        Biking newBiking = new Biking(date3, duration3);
        newRunning.SetDistance(distancekm1);
        newBiking.SetDistance(distancekm3);

        List<Activity> activities = new List<Activity>();
        activities.Add(newRunning);
        activities.Add(newSwimming);
        activities.Add(newBiking);

        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}

// 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile