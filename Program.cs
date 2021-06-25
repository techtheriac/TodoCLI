using System;

namespace TodoCLI
{
    class Program
    {

        // Project interface is implemented here
        static void Main(string[] args)
        {
            TodoApp Application = new TodoApp();

            Application.AddTodo("Kill Jane");
            Application.AddTodo("Kill John");
            Application.AddTodo("Watch Porn");
            Application.AddTodo("Jesus is Lord");

            Application.Print();
        }


    }
}
