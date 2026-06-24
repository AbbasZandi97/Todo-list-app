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
                Console.WriteLine("Invalid input.");
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
