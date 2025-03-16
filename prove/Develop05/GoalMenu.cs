public class GoalMenu : Menu
{
    public GoalMenu()
    {

    }

    public override void DisplayMenu()
    {
        Console.WriteLine("Which goal would you like to create? ");
        Console.WriteLine();
        Console.WriteLine("The types of goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Please select a choice from the menu: ");
    }
}