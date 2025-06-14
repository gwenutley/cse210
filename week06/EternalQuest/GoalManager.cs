using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {

    }

    public void Start()
    {
        DisplayInstructions();
    }

    public void DisplayInstructions()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalNames();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                SaveGoal();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                LoadGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                RecordEvent();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == 6)
            {
                return;
            }
            else
            {
                Console.WriteLine("Choose a valid number");
            }
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are:");
        if (_goals.Count() == 0)
        {
            Console.WriteLine("You have no goals");
            return;
        }

        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("They types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string goalinput = Console.ReadLine();
        int goal;
        if (!int.TryParse(goalinput, out goal))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal? ");
        string pointsInput = Console.ReadLine();
        int goalPoints;
        if (!int.TryParse(pointsInput, out goalPoints))
        {
            Console.WriteLine("Please enter a valid number for points.");
            return;
        }

        if (goal == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (goal == 2)
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (goal == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string inputTarget = Console.ReadLine();
            int target;
            if (!int.TryParse(inputTarget, out target))
            {
                Console.WriteLine("Please enter a valid number for target.");
                return;
            }
            Console.WriteLine("What is the bonus for acconplishing it that many times?");
            string inputBonus = Console.ReadLine();
            int bonus;
            if (!int.TryParse(inputBonus, out bonus))
            {
                Console.WriteLine("Please enter a valid number for bonus.");
            }
            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus));
        }
        else
        {
            Console.WriteLine("Please enter valid input.");
            return;
        }
        Console.WriteLine("Successfully created");
    }


    public void RecordEvent()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine("You have no goals.");
            return;
        }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }

        Console.WriteLine("Which goal did you accomplish? ");
        string accomplishedInput = Console.ReadLine();
        int accomplished;
        if (!int.TryParse(accomplishedInput, out accomplished))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        Goal finishedGoal = _goals[accomplished - 1];
        finishedGoal.RecordEvent();
        _score += finishedGoal.GetPoints();

        if (finishedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete() == true && checklist.GetAmountComplete() == checklist.GetTarget())
            {
                _score += checklist.GetBonus();
            }
        }
        Console.WriteLine($"You gained {finishedGoal.GetPoints()} points");
        Console.WriteLine($"You now have {_score} points!");


    }

    public void SaveGoal()
    {
        Console.WriteLine("Emter filename to save your goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("successfully saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File doesn't exist");
            return;
        }

        _goals.Clear();

        string[] savedGoals = File.ReadAllLines(filename);
        if (savedGoals.Length == 0)
        {
            Console.WriteLine("You have no saved goals.");
            return;
        }

        int.TryParse(savedGoals[0], out _score);

        for (int i = 1; i < savedGoals.Length; i++)
        {
            string goal = savedGoals[i];
            string[] parts = goal.Split("-");
            if (parts.Length == 0) continue;

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string describe = parts[2];
                int points = int.Parse(parts[3]);

                _goals.Add(new SimpleGoal(name, describe, points));
            }

            if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string describe = parts[2];
                int points = int.Parse(parts[3]);

                _goals.Add(new EternalGoal(name, describe, points));
            }

            if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string describe = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountComplete = int.Parse(parts[6]);

                ChecklistGoal checklist = new ChecklistGoal(name, describe, points, target, bonus);
                checklist.SetAmountComplete(amountComplete);
                _goals.Add(checklist);
            }


        }
        Console.WriteLine("Successfully Loaded");
    



    }
}
