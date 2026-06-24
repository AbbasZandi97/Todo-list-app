using TodoApp.service;
using TodoApp.Ui;

namespace TodoApp
{
    // Application entry point
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoService service = new TodoService();
            service.StartProgram();
        }
    }
}
