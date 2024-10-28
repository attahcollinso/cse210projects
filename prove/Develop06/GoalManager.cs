public class GoalManager
{
   private List<Goal> _goals;
   private int _score;

   public GoalManager()
   {
      _score = 0;
      _goals = new List<Goal>();
   }

   public void Start()
   {
      Console.Write("Enter your Username: ");
      string username = Console.ReadLine();
      User user = new User(username, _score);
      if (! user.IsNewUser())
      {
         user.LoadFromFile();
         _score = user._score;
      }
      int choice = 0;
      while (choice != 6)
      {
         Console.Clear();
         DisplayPlayerInfo();
         Console.WriteLine("Menu Options");
         Console.WriteLine($"    1. Create New Goal");
         Console.WriteLine($"    2. List Goals");
         Console.WriteLine($"    3. Save Goals");
         Console.WriteLine($"    4. Load Goals");
         Console.WriteLine($"    5. Record Event");
         Console.WriteLine($"    6. Quit.");
         Console.Write("Select a choice from menu ");
         int.TryParse(Console.ReadLine(), out choice);
         switch (choice)
         {
            case 1:
               CreateGoal();
               break;
            case 2:
               ListGoalDetails();
               break;
            case 3:
               SaveGoals();
               break;
            case 4:
               LoadGoals();
               break;
            case 5:
               RecordEvent();
               break;
         }
         
      }

      user._score = _score;
      user.Save();
   }

   public void DisplayPlayerInfo()
   {
      Console.WriteLine($"You have {_score} points.");
   }

   public void ListGoalNames()
   {
      {
         for (int i = 0; i < _goals.Count; i++)
         {
            Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
         }
      }
   }

   public void ListGoalDetails()
   {
      for (int i = 0; i < _goals.Count; i++)
      {
         Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
      }

      Console.ReadLine();
   }

   public void CreateGoal()
   {
      string name;
      string description = "";
      string points = "";
      int choice = 0;
      Console.WriteLine("The types of Goals are: ");
      Console.WriteLine("  1. Simple Goal");
      Console.WriteLine("  2. Eternal Goal");
      Console.WriteLine("  3. Checklist Goal");
      Console.Write("Which type of Goal would you like to create or press 6 to menu: ");
      int.TryParse(Console.ReadLine(), out choice);
      switch (choice)
      {
         case 1:
            Console.Write("What is the name of the Goal? ");
            name = Console.ReadLine();
            Console.Write("Describe your Goal. ");
            description = Console.ReadLine();
            Console.Write("How many points you want to receive for completion of this goal: ");
            points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            break;
         case 2:
            Console.Write("What is the name of the Goal? ");
            name = Console.ReadLine();
            Console.Write("Describe your Goal. ");
            description = Console.ReadLine();
            Console.Write("How many points you want to receive for completion of this goal: ");
            points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            break;
         case 3:
            Console.Write("What is the name of the Goal? ");
            name = Console.ReadLine();
            Console.Write("Describe your Goal. ");
            description = Console.ReadLine();
            Console.Write("How many points you want to receive for completion of this goal: ");
            points = Console.ReadLine();
            Console.Write("How many time I need to complete this goal to get bonus: ");
            int target = int.TryParse(Console.ReadLine(), out target) ? target : 0;
            Console.Write("How many bonus points I will get for completion: ");
            int bonus = int.TryParse(Console.ReadLine(), out bonus) ? bonus : 0;
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            break;
         case 6:
            break;
      }
      
   }

   public void RecordEvent()
   {
      int choice = -1;
      ListGoalNames();
      Console.Write("What goal did you accomplish? ");
      int.TryParse(Console.ReadLine(), out choice);
      _goals[choice-1].RecordEvent();
      _score = _score + int.Parse(_goals[choice - 1]._points);
      Console.WriteLine($"Congratulations you have earned {_goals[choice-1]._points}");
   }

   public void SaveGoals()
   {
      Console.Write("Enter filename for goals file: ");
      string filename = Console.ReadLine();
      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         foreach (Goal goal in _goals)
         {
            outputFile.WriteLine(goal.GetStringRepresentation());
         }
      }
   }

   public void LoadGoals()
   {
      Console.Write("Enter filename for goals file: ");
      string filename = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines(filename);
      foreach (string line in lines)
      {
         string[] parts = line.Split(",");
         switch (parts[0])
         {
            case "S":
               SimpleGoal sg = new SimpleGoal(parts[1], parts[2], parts[3]);
               if (parts[4] == "True")
                  sg.RecordEvent();
               _goals.Add(sg);
               break;
            case "E":
               EternalGoal eg = new EternalGoal(parts[1], parts[2], parts[3]);
               _goals.Add(eg);
               break;
            case "C":
               ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]),
                  int.Parse(parts[5]));
               for (int i = 0; i < int.Parse(parts[6]); i++)
               {
                  cg.RecordEvent();
               }
               _goals.Add(cg);
               break;
         }
         
      }
      {
         
      }
   }
}