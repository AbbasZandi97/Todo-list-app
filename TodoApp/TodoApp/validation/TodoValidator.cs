using TodoApp.model;
using TodoApp.repository;

namespace TodoApp.validation
{
    // validates the todo description and checks the list to not be empty
    internal class TodoValidator
    {
        public static bool IsToDoUnique(string toDoToBeChecked, List<Todo> listOfToDos)
        { 
            foreach(var toDo in listOfToDos)
            {
                if (toDo.Description.Equals(toDoToBeChecked))
                    return false;
            }

            return true;
        }

        public static bool IsToDoEmpty(string toDoToBeChecked)
        {
            return string.IsNullOrWhiteSpace(toDoToBeChecked);
        }

        

    }
}
