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
            foreach (TodoItem todo in TodoList)
            {
                Console.WriteLine($"|{todo.Id} \t| {todo.Todo} \t| {todo.Completed}");
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

    }
}
