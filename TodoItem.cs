using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCLI
{
    class TodoItem
    {
        private string _todo;
        private bool _completed { get; set; } = false;

        public TodoItem(string todo)
        {
            _todo = todo;
        }

        public int Id => Counter.GetNextValue();

        public string Todo
        {
            get => _todo;
            set => _todo = value;
        }

        public bool Completed
        {
            get => _completed;
            set => _completed = value;
        }

    }
}
