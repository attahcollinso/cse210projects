Public class GoalManager
{
   Private List<Goal> _goals;
   Private int _score;

   Public GoalManager()
   {
      _score = 0;
      _goals = new List<Goal>();
   }

   Public void Start()
   {
      Console.Write(“Enter your Username: “);
      String username = Console.ReadLine();
      User user = new User(username, _score);
      If (! User.IsNewUser())
      {
         User.LoadFromFile();
         _score = user._score;
      }
      Int choice = 0;
      While (choice != 6)
      {
         Console.Clear();
         DisplayPlayerInfo();
         Console.WriteLine(“Menu Options”);
         Console.WriteLine($”    1. Create New Goal”);
         Console.WriteLine($”    2. List Goals”);
         Console.WriteLine($”    3. Save Goals”);
         Console.WriteLine($”    4. Load Goals”);
         Console.WriteLine($”    5. Record Event”);
         Console.WriteLine($”    6. Quit.”);
         Console.Write(“Select a choice from menu “);
         Int.TryParse(Console.ReadLine(), out choice);
         Switch (choice)
         {
            Case 1:
               CreateGoal();
               Break;
            Case 2:
               ListGoalDetails();
               Break;
            Case 3:
               SaveGoals();
               Break;
            Case 4:
               LoadGoals();
               Break;
            Case 5:
               RecordEvent();
               Break;
         }
         
      }

      User._score = _score;
      User.Save();
   }

   Public void DisplayPlayerInfo()
   {
      Console.WriteLine($”You have {_score} points.”);
   }

   Public void ListGoalNames()
   {
      {
         For (int I = 0; I < _goals.Count; i++)
         {
            Console.WriteLine($”{i+1}. {_goals[i].GetDetailsString()}”);
         }
      }
   }

   Public void ListGoalDetails()
   {
      For (int I = 0; I < _goals.Count; i++)
      {
         Console.WriteLine($”{i+1}. {_goals[i].GetDetailsString()}”);
      }

      Console.ReadLine();
   }

   Public void CreateGoal()
   {
      String name;
      String description = “”;
      String points = “”;
      Int choice = 0;
      Console.WriteLine(“The types of Goals are: “);
      Console.WriteLine(“  1. Simple Goal”);
      Console.WriteLine(“  2. Eternal Goal”);
      Console.WriteLine(“  3. Checklist Goal”);
      Console.Write(“Which type of Goal would you like to create or press 6 to menu: “);
      Int.TryParse(Console.ReadLine(), out choice);
      Switch (choice)
      {
         Case 1:
            Console.Write(“What is the name of the Goal? “);
            Name = Console.ReadLine();
            Console.Write(“Describe your Goal. “);
            Description = Console.ReadLine();
            Console.Write(“How many points you want to receive for completion of this goal: “);
            Points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            Break;
         Case 2:
            Console.Write(“What is the name of the Goal? “);
            Name = Console.ReadLine();
            Console.Write(“Describe your Goal. “);
            Description = Console.ReadLine();
            Console.Write(“How many points you want to receive for completion of this goal: “);
            Points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            Break;
         Case 3:
            Console.Write(“What is the name of the Goal? “);
            Name = Console.ReadLine();
            Console.Write(“Describe your Goal. “);
            Description = Console.ReadLine();
            Console.Write(“How many points you want to receive for completion of this goal: “);
            Points = Console.ReadLine();
            Console.Write(“How many time I need to complete this goal to get bonus: “);
            Int target = int.TryParse(Console.ReadLine(), out target) ? target : 0;
            Console.Write(“How many bonus points I will get for completion: “);
            Int bonus = int.TryParse(Console.ReadLine(), out bonus) ? bonus : 0;
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            Break;
         Case 6:
            Break;
      }
      
   }

   Public void RecordEvent()
   {
      Int choice = -1;
      ListGoalNames();
      Console.Write(“What goal did you accomplish? “);
      Int.TryParse(Console.ReadLine(), out choice);
      _goals[choice-1].RecordEvent();
      _score = _score + int.Parse(_goals[choice – 1]._points);
      Console.WriteLine($”Congratulations you have earned {_goals[choice-1]._points}”);
   }

   Public void SaveGoals()
   {
      Console.Write(“Enter filename for goals file: “);
      String filename = Console.ReadLine();
      Using (StreamWriter outputFile = new StreamWriter(filename))
      {
         Foreach (Goal goal in _goals)
         {
            outputFile.WriteLine(goal.GetStringRepresentation());
         }
      }
   }

   Public void LoadGoals()
   {
      Console.Write(“Enter filename for goals file: “);
      String filename = Console.ReadLine();
      String[] lines = System.IO.File.ReadAllLines(filename);
      Foreach (string line in lines)
      {
         String[] parts = line.Split(“,”);
         Switch (parts[0])
         {
            Case “S”:
               SimpleGoal sg = new SimpleGoal(parts[1], parts[2], parts[3]);
               If (parts[4] == “True”)
                  Sg.RecordEvent();
               _goals.Add(sg);
               Break;
            Case “E”:
               EternalGoal eg = new EternalGoal(parts[1], parts[2], parts[3]);
               _goals.Add(eg);
               Break;
            Case “C”:
               ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]),
                  Int.Parse(parts[5]));
               For (int I = 0; I < int.Parse(parts[6]); i++)
               {
                  Cg.RecordEvent();
               }
               _goals.Add(cg);
               Break;
         }
         
      }
      {
         
      }
   }
}
