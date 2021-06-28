using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCLI
{
    public class TodoApp
    {
        List<TodoItem> TodoList = new List<TodoItem> { };

        public void Print()
        {
            int computeGreatestLength ()
            {
                List<int> stringLength = new List<int> { };
                Index last = ^1;
                foreach (TodoItem item in TodoList)
                {
                    stringLength.Add(item.Todo.Length);
                }
                stringLength.Sort();
                return stringLength[last];
            }

            int greatestTodoStringLength = computeGreatestLength();

            string computeSpaceRequired(string todo)
            {
                int stringLengthDifference = greatestTodoStringLength - todo.Length;
                string spaceRequired = "";

                for(int i = 0; i < stringLengthDifference; i ++)
                {
                    spaceRequired += " ";
                }

                return spaceRequired;
            }
            
            foreach (TodoItem todo in TodoList)
            {
                string printedString =
                $"|{todo.Id} \t| {todo.Todo} {computeSpaceRequired(todo.Todo)}| {todo.Completed}";

                Console.WriteLine(printedString);
            }
        }

        public void AddTodo(string todo)
        {
            TodoList.Add(new TodoItem(todo));
        }

        public void CompleteTodo(int id)
        {
            foreach (TodoItem item in TodoList)
            {
                if(item.Id == id)
                {
                    item.Completed = true;
                }
            }
        }

        public void CommandInterface ()
        {
            void AddItemProcedure ()
            {
                Console.WriteLine("What would you like to add to your list of Todos?");
                string n = Console.ReadLine();
                AddTodo(n);
            }

            List<string> Actions = new List<string>
            {
                "1. Add Item Todo",
                "2. Print All Todo Items",
                "3. Remove A Todo",
                "4. Terminate Application"
            };
            Console.WriteLine("Welcome to the most perverted TODO CLI");
            Console.WriteLine("Respond with the preceeding number to perform an action");

            foreach (string action in Actions)
            {
                Console.WriteLine(action);
            }

            string action_ = Console.ReadLine();

            switch (action_)
            {
                case "1":
                    AddItemProcedure();
                    Print();
                    break;
                case "3":
                    Print();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

        }

    }
}
