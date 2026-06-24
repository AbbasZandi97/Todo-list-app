using TodoApp.model;
using TodoApp.repository;
using TodoApp.Ui;
using TodoApp.validation;

namespace TodoApp.service
{
    // recieves requests from UI and uses validator and repository
    internal class TodoService
    {
        private readonly TodoRepository _repository;
        private readonly List<Todo> _todoList;
        
        public TodoService()
        {
            _repository = new TodoRepository();
            _todoList = _repository.GetToDos();
        }

        
        public void StartProgram()
        {
            Console.WriteLine("Hello!");

            do
            {
                ConsoleUi.PrintMenu();
                string input = ConsoleUi.GetChoice();
                
                if (input.Equals("E"))
                {
                    Console.WriteLine("Closing the App....");
                    break;
                }
                
                ExecuteTask(input, _repository);
            }
            while (true);
        }
        
        
        
        
        
        public void ExecuteTask(string input, TodoRepository repo)
        {
            if (input.Equals("S"))
            {
                repo.SeeAllToDos();
            }
            else if (input.Equals("A")) {
 
                repo.AddToDo();
            }
            else // this part gets R
            {
                repo.RemoveToDo();
            }

            
        }
    }
}
