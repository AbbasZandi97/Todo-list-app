using TodoApp.model;
using TodoApp.Ui;
using TodoApp.validation;

namespace TodoApp.repository
{
    // keeps the collection of todos and executes related operations
    internal class TodoRepository
    {
        private readonly List<Todo> _toDos;

        public TodoRepository()
        {
            _toDos = new List<Todo>();
        }

        public void AddToDo()
        {
            string task = ConsoleUi.GetTaskToAdd();
            if (!TodoValidator.IsToDoUnique(task, _toDos))
            {
                Console.WriteLine("Entered task is already in the list.");
                Console.WriteLine("Enter a new value: ");
                AddToDo();
            }
            else if (TodoValidator.IsToDoEmpty(task))
            {
                Console.WriteLine("You entered nothing or an empty task.");
                Console.WriteLine("Enter a valid task again: ");
                AddToDo();
            }
            
            _toDos.Add(new Todo(task));
            Console.WriteLine("Task added successfully!!\n");
        }

        public void RemoveToDo()
        {  
            if (IsListEmpty())
            {
                ConsoleUi.PrintListIsEmpty();
                return;
            }

            SeeAllToDos();
            int index = ConsoleUi.GetIndexToRemove();
            index--;
            string deletedTask = _toDos[index].Description;
            _toDos.RemoveAt(index);
            Console.WriteLine("Following task removed: ");
            Console.WriteLine(deletedTask);
            Console.WriteLine();
        }           

        public void SeeAllToDos()
        {
            if (IsListEmpty())
            {
                ConsoleUi.PrintListIsEmpty();
                return;
            }
            
            int index = 1;
            foreach (var item in _toDos)
            {
                Console.WriteLine($"{index}: {item.Description}");
                index++;
            }
            Console.WriteLine();
        }

        public List<Todo> GetToDos()
        {
            return _toDos;
        }

        public bool IsListEmpty()
        {
            if (_toDos.Count == 0) return true;  
            
            return false;
        }
    }
}
