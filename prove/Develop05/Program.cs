using System;

//For extra credit, I added a streak bonus to the "Eternal Goal" class, which keeps track of how many times you have completed the task
//and awards bonus points based on how long the streak is.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}