using System.Diagnostics;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _userXP;
    private int _userLevel;
    public GoalManager()
    {
        _userXP = 0;
        _userLevel = 1;
    }

    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            string userResponse = Console.ReadLine();
            if (userResponse == "1")
            {
                CreateGoal();
            }
            else if (userResponse == "2")
            {
                Console.Clear();
                Console.WriteLine("Here is a list of your current goals: \n");
                DisplayGoals(true);
            }
            else if (userResponse == "3")
            {
                Console.Clear();
                Console.WriteLine("That is the name of the .txt file you would like to save your goals to? ");
                string userFile = Console.ReadLine();
                SaveGoalsToFile(userFile);
            }
            else if (userResponse == "4")
            {
                Console.Clear();
                Console.WriteLine("That is the name of the .txt file you would like to load your goals from? ");
                string userFile = Console.ReadLine();
                LoadGoalsFromFile(userFile);
            }
            else if (userResponse == "5")
            {
                RecordEvent();
            }
            else {break;}
        }

    }

    public void DisplayMenu()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("What Kind of Goal would you like to create? ");
        Console.WriteLine("\t1. Simple (one and done)");
        Console.WriteLine("\t2. Checklist (complete a certain number of times)");
        Console.WriteLine("\t3. Eternal (never ending)");
        Console.WriteLine("Please select one of these menu options, or press 4 to go back.");
        string userResponse = Console.ReadLine();
        if (userResponse != "1" && userResponse != "2" && userResponse != "3") 
        {
            Console.Clear();
            return;
        }

        Console.WriteLine("\nWhat is the name of this goal?");
        string goalName = Console.ReadLine();

        Console.WriteLine("\nWhat are the details (specifics) of completing this goal? ");
        string goalDetails = Console.ReadLine();

        Console.WriteLine("\nHow many Experience Points (XP) should completing this goal be worth? ");
        string goalXPString = Console.ReadLine();
        int goalXP = int.Parse(goalXPString);

        if (userResponse == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(goalName, goalDetails, goalXP);
            _goals.Add(newGoal);
            Console.WriteLine("\nThe Simple Goal has been created!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (userResponse == "2")
        {
            Console.WriteLine("\nHow many times do you want to complete this goal? ");
            string completionsString = Console.ReadLine();
            int completions = int.Parse(completionsString);

            Console.WriteLine($"\nAnd how much extra XP should you get after completing this goal {completions} times?");
            string bonusString = Console.ReadLine();
            int bonusPoints = int.Parse(bonusString);

            ChecklistGoal newGoal = new ChecklistGoal(goalName, goalDetails, goalXP, completions, bonusPoints);
            _goals.Add(newGoal);
            Console.WriteLine("\nThe Checklist Goal has been created!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (userResponse == "3")
        {
            Console.WriteLine("What do you want the streak bonus to be for completing this goal daily?");
            string bonusString = Console.ReadLine();
            int bonusPoints = int.Parse(bonusString);

            EternalGoal newGoal = new EternalGoal(goalName, goalDetails, goalXP, bonusPoints);
            _goals.Add(newGoal);
            Console.WriteLine("\nThe Eternal Goal has been created!");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    public void LoadGoalsFromFile(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                if (parts[0] == "simple")
                {
                    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (parts[4] == "True")
                    {
                        goal.Complete();
                    }
                    _goals.Add(goal);
                } 
                else if (parts[0] == "eternal")
                {
                    EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]));
                    if (parts[4] == "True")
                    {
                        goal.Complete();
                    }
                    goal.SetStreak(int.Parse(parts[6]));
                    _goals.Add(goal);
                }
                else if (parts[0] == "checklist")
                {
                    ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),int.Parse(parts[5]), int.Parse(parts[6]));
                    if (parts[4] == "True")
                    {
                        goal.Complete();
                    }
                    goal.SetCurrentCompletions(int.Parse(parts[7]));
                    _goals.Add(goal);
                }
                else if (parts[0] == "XP")
                {
                    _userXP = int.Parse(parts[1]);
                    _userLevel = int.Parse(parts[2]);
                }
            }
            Console.WriteLine("The goals have successfully been loaded!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured while loading the file: " + ex.Message);
        }
    }

    public void SaveGoalsToFile(string fileName)
    {
        try
        {
            string content = "";

            content += $"XP,{_userXP},{_userLevel}\n";

            foreach (Goal goal in _goals)
            {
                content += goal.GetStringRepresentation() + "\n";
            }
            File.WriteAllText(fileName, content);
            Console.WriteLine("Goals saved successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Error occured while saving the file: " + ex.Message);
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Level: {_userLevel}\nCurrent XP: {_userXP}");
    }

    public void DisplayGoals(bool detailed)
    {
        if (detailed)
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
            }
        }
        Thread.Sleep(1000);
    }

    public void RecordEvent()
    {
        Console.WriteLine("For which goal would you like to update an event? Enter the number of the goal to update. ");
        DisplayGoals(false);
        string userDecision = Console.ReadLine();
        int additionalXP = _goals[int.Parse(userDecision) - 1].RecordEvent();
        addXP(additionalXP);
        
        Console.WriteLine("You have succesfully updated the goal!");
    }

    public void addXP(int newXP)
    {
        _userXP += newXP;
        double tempXP = _userXP;
        tempXP -= _userLevel * 100;
        if (tempXP / 100 > 1)
        {
            Console.WriteLine("You have leveled up!");
            tempXP = tempXP / 100;
            _userLevel += (int)Math.Floor(tempXP);
        }
    }
   // GoalManager (Awarding Points, Updating / Saving / Loading / Creating new Goals)
}