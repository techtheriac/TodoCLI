using System;

namespace TodoCLI
{
    class Program
    {

        // Project interface is implemented here
        static void Main(string[] args)
        {
            TodoApp Application = new TodoApp();

            Application.CommandInterface();
        }


    }
}
