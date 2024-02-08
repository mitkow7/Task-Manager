
class TaskManager
{
        static List<string> titles = new List<string>();
        static List<string> descriptions = new List<string>();
        static List<string> deadlines = new List<string>();
        static List<int> priorities = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Create a task");
                Console.WriteLine("2: Your tasks");
                Console.WriteLine("3: Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                case 1:
                    CreateTasks();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
                }

                Console.WriteLine();
            }
        }

        private static void ViewTasks()
        {
            if (titles.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No tasks created");
            Console.ForegroundColor = ConsoleColor.White;
            return;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("List of added tasks:");
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
            for (int i = 0; i < titles.Count; i++)
            {
                Console.WriteLine($"Title: {titles[i]}");
                Console.WriteLine($"Description: {descriptions[i]}");
                Console.WriteLine($"Deadline: {deadlines[i].ToString()}");
                Console.WriteLine($"Priority: {GetPriorityDescription(priorities[i])}");
                Console.WriteLine();
            }
        }

        private static void CreateTasks()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Create a new task");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Deadline (yyyy.mm.dd): ");
            string deadline = Console.ReadLine();
            Console.Write("Priority (1 - low, 2 - medium, 3 - high): ");
            int priority = int.Parse(Console.ReadLine());

            titles.Add(title);
            descriptions.Add(description);
            deadlines.Add(deadline);
            priorities.Add(priority);
        }

        static string GetPriorityDescription(int priority)
        {
            switch (priority)
            {
            case 1:
                return "Low";
            case 2:
                return "Medium";
            case 3:
                return "High";
            default:
                return "Invalid priority index";
            }
        }
}
