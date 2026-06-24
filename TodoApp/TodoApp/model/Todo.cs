namespace TodoApp.model
{
    // represents a single todo item and holds its data
    internal class Todo
    {
        public string Description { get; private set; }

        public Todo(string description)
        {
            Description = description;
        }

    }
}
