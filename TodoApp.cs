using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCLI
{
    public class TodoApp
    {
        List<TodoItem> TodoList = new List<TodoItem> { };

        List<string> Instructions = new List<string>
        {
            "* Type --help anytime to view help and command listing",
            "* `-D` - Delete an Item",
            "* `-C` - Mark an item as completed"
        };

        List<string> Actions = new List<string>
        {
                "1. Add Item Todo",
                "2. View Help Listing"
        };
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

        void PrintHelp()
        {
            foreach (var item in Instructions)
            {
                Console.WriteLine(item);
            }
        }

        public void AddTodo(string todo)
        {
            if(todo != "-C" && todo != "--help" && todo != "-D")
            {
            TodoList.Add(new TodoItem(todo));
            }
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

            Console.WriteLine("Task DONE");
        }

        public void DeleteTodo(int id)
        {
            foreach (TodoItem item in TodoList)
            {
                if (item.Id == id)
                {
                    TodoList.Remove(item);
                    break;
                }
            }

            Console.WriteLine("Task Removed");
        }

        public void CommandInterface ()
        {
            void AddItemProcedure ()
            {
                for(int i = 0; i < short.MaxValue; i++)
                {
                    Console.WriteLine("What would you like to add to your list of Todos?");
                    string n = Console.ReadLine();
                    AddTodo(n);
                    Print();

                    if (n == "--help")
                    {
                        PrintHelp();
                    } else if(n == "-C") {
                        Console.WriteLine("Insert item number to mark as completed");
                        int c = Int32.Parse(Console.ReadLine());
                        CompleteTodo(c);
                    } else if (n == "-D") {
                        Console.WriteLine("Insert item number to delete item");
                        int d = Int32.Parse(Console.ReadLine());
                        DeleteTodo(d);
                    }
                    {
                        AddItemProcedure();
                    }
                }

            }


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
                    break;
                case "2":
                    PrintHelp();
                    AddItemProcedure();
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }

        }

    }
}
