using TodoApp.model;

namespace TodoApp.Ui
{
    // interacts with user input and displays the messages
    internal class ConsoleUi
    {

        public static void PrintMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOS");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit\n");
        }

        public static void PrintListIsEmpty()
        {
            Console.WriteLine("Your List is empty.");
            Console.WriteLine("You need to enter a task first.\n");
        }

        public static void PrintRemovedTask(string removedTask)
        {
            Console.WriteLine("Following task removed: ");
            Console.WriteLine(removedTask);
            Console.WriteLine();
        }

        public static void PrintTaskIsUnique()
        {
            Console.WriteLine("Entered task is already in the list.");
            Console.WriteLine("Enter a new value: ");
        }
        public static void PrintEmptyTask()
        {
            Console.WriteLine("You entered nothing or an empty task.");
            Console.WriteLine("Enter a valid task again: ");
        }
        public static string GetChoice()
        {
            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (!IsChoiceValid(input));

            return input.ToUpper();
        }

        public static bool IsChoiceValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty input.");
                Console.WriteLine("Try again: ");
                PrintMenu();
                return false;
            }

            switch(input)
            {
                case "S":
                case "s":
                case "A":
                case "a":
                case "R":
                case "r":
                case "E":
                case "e":
                    return true;
                default:
                    Console.WriteLine("Invalid Input.");
                    Console.WriteLine("Try again.");
                    PrintMenu();
                    return false;
            }

        }

        public static string GetTaskToAdd()
        {
            Console.WriteLine("Enter task: ");
            return Console.ReadLine();
        }

        public static int GetIndexToRemove(List<Todo> list)
        {
            string index;
            do
            {
                Console.WriteLine("Enter number of the task to remove: ");
                index = Console.ReadLine();
            }
            while (!IsIndexValid(index, list));

            return int.Parse(index);

        }

        public static bool IsIndexValid(string input, List<Todo> list)
        {
            bool isParsable = int.TryParse(input, out int parsedInput);
            if (!isParsable)
            {
                Console.WriteLine("input is not a number.");
                Console.WriteLine("Please enter a number as index: ");
                return false;
            } 
            
            if (parsedInput < 1 || parsedInput > list.Count)
            {
                Console.WriteLine("Index is out of range.");
                Console.WriteLine("Try again: ");
                return false;
            }

            return true;
        }

        

    }
}
