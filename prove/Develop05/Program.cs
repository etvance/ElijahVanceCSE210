using System;

class Program
{
    static void Main(string[] args)
    {
        Menu m = new Menu();
        GoalMenu gm = new GoalMenu();
        FileHandler f = new FileHandler();
        User u = new User();



        while (m.GetMenuInput() != 6)
        {
            int scoreLoad = f.GetScoreLoad();
            u.UpdateScore(scoreLoad);
            
            Console.Clear();
            u.DisplayScore();
            Console.WriteLine();

            m.DisplayMenu();
            string menuInput = Console.ReadLine();
            m.SetMenuInput(menuInput);

            switch (m.GetMenuInput())
            {
                case 1:
                    Console.Clear();
                    gm.DisplayMenu();
                    string input = Console.ReadLine();
                    gm.SetMenuInput(input);
                    switch (gm.GetMenuInput())
                    {
                        case 1:
                            Console.Write("What would you like to name the goal: ");
                            string name = Console.ReadLine();
                            Console.Write("Give a short description of this goal: ");
                            string description = Console.ReadLine();
                            Console.Write("How many points would you like this goal to be worth?: ");
                            string uInput = Console.ReadLine();
                            int points = int.Parse(uInput);
                            SimpleGoal s = new SimpleGoal(name, description, points);

                            f.AddGoal(s);

                            Console.WriteLine();
                            Console.WriteLine($"The goal of {name} has been created!");
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("What would you like to name the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Give a short description of this goal: ");
                            description = Console.ReadLine();
                            Console.Write("How many points would you like this goal to be worth?: ");
                            uInput = Console.ReadLine();
                            points = int.Parse(uInput);
                            EternalGoal e = new EternalGoal(name, description, points);

                            f.AddGoal(e);

                            Console.WriteLine();
                            Console.WriteLine($"The goal of {name} has been created!");
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;

                        case 3:

                            Console.Write("Please provide a name for the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Please give a short description of your goal: ");
                            description = Console.ReadLine();
                            Console.Write("How many points would you like a single completion to be worth?: ");
                            uInput = Console.ReadLine();
                            points = int.Parse(uInput);
                            Console.Write("How many times do you want this goal to be completed? ");
                            uInput = Console.ReadLine();
                            int totalTimes = int.Parse(uInput);
                            Console.Write("What is the bonus for completing the entire goal? ");
                            uInput = Console.ReadLine();
                            int bonusPoints = int.Parse(uInput);
                        
                            ChecklistGoal cl = new ChecklistGoal(name, description, points, bonusPoints, totalTimes);

                            f.AddGoal(cl);

                            Console.WriteLine();
                            Console.WriteLine($"The goal of {name} has been created!");
                            Console.Write("Press enter to return to the menu");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case 2:

                    Console.Clear();
                    f.ListGoals();
                    Console.WriteLine();
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();

                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("File save:");
                    Console.WriteLine();
                    Console.Write("What would you like to name the file? ");
                    f.SaveFiles(Console.ReadLine(), u.GetScore());
                    Console.WriteLine("Your file has been saved");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();

                break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("File Load:");
                    Console.WriteLine();
                    Console.Write("What is the name of the file you wish to Load? ");

                    f.LoadFiles(Console.ReadLine());
                    Console.WriteLine("Load complete!");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();
                break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Which goal did you achieve?");
                    Console.WriteLine();
                    f.ListGoals();
                    Console.WriteLine();

                    Console.Write("Please select a goal from the list: ");
                    Goal goal = f.GetGoal(int.Parse(Console.ReadLine()));
                    int bonus = goal.CompleteGoal();
                    u.UpdateScore(bonus);
                    int awardedpoints = goal.GetPoints();
                    u.UpdateScore(awardedpoints);

                    
                    Console.WriteLine("Your goal has been recorded");
                    Console.WriteLine($"Congratulations! You have been awarded {awardedpoints + bonus}");
                    Console.Write("Press enter to return to the menu");
                    Console.ReadLine();
                break;

            }
        }
    }
}