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
            while (true)
            {
                string task = ConsoleUi.GetTaskToAdd();
                if (!TodoValidator.IsToDoUnique(task, _toDos))
                {
                    ConsoleUi.PrintTaskIsUnique();
                    continue;
                }
                
                if (TodoValidator.IsToDoEmpty(task))
                {
                    ConsoleUi.PrintEmptyTask();
                    continue;
                }

                _toDos.Add(new Todo(task));
                Console.WriteLine("Task added successfully!!\n");
                return;
            }

            
        }

        public void RemoveToDo()
        {  
            if (IsListEmpty())
            {
                ConsoleUi.PrintListIsEmpty();
                return;
            }

            SeeAllToDos();
            int index = ConsoleUi.GetIndexToRemove(_toDos);
            index--;
            string deletedTask = _toDos[index].Description;
            _toDos.RemoveAt(index);
            ConsoleUi.PrintRemovedTask(deletedTask);
            
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
            return _toDos.Count == 0;
        }
    }
}
