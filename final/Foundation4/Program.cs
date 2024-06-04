using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running("03 Nov 2023", 30.0, 2.0);
        activities.Add(running1);

        Cycling cycling1 = new Cycling("12 Aug 2024", 45.0, 31.2);
        activities.Add(cycling1);

        Swimming swimming1 = new Swimming("21 Sep 2020", 60.0, 80);
        activities.Add(swimming1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}