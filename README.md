# TodoApp

A simple console-based Todo List application built with C# and .NET 10, created as a learning project to practice Object-Oriented Programming (OOP) and the Single Responsibility Principle (SRP).

---

## Features

- Add a new todo task
- Remove an existing todo task by index
- View all current todo tasks
- Input validation (empty tasks, duplicate tasks, invalid menu choices)

---

## Project Structure

```
TodoApp/
├── model/
│   └── Todo.cs               # Represents a single todo item
├── repository/
│   └── TodoRepository.cs     # Manages the todo collection (add, remove, list)
├── service/
│   └── TodoService.cs        # Handles program flow and user request routing
├── validation/
│   └── TodoValidator.cs      # Validates task input (empty, duplicate)
├── Ui/
│   └── ConsoleUi.cs          # Handles all console input and output
└── Program.cs                # Application entry point
```

---

## How to Run

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) installed on your machine

### Steps

1. Clone the repository:

   ```bash
   git clone https://github.com/AbbasZandi97/Todo-list-app.git
   ```

2. Navigate into the project folder:

   ```bash
   cd TodoApp/TodoApp
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

---

## How to Use

When you run the app, you will see a menu:

```
What do you want to do?
[S]ee all TODOS
[A]dd a TODO
[R]emove a TODO
[E]xit
```

- Press **S** or **s** to see all your current tasks
- Press **A** or **a** to add a new task
- Press **R\* or **r\*\* to remove a task by its number
- Press **E** or **e** to exit the app

---

## Concepts Practiced

- **Single Responsibility Principle (SRP):** Each class has one clear job — `Todo` holds data, `TodoRepository` manages the list, `TodoService` controls flow, `ConsoleUi` handles I/O, and `TodoValidator` handles a TODO validation.
- **Object-Oriented Programming (OOP):** Use of classes, encapsulation, and separation of concerns.
- **Layered Architecture:** Clean separation between UI, service, repository, and model layers.
