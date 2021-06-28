using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCLI
{
    class TodoItem
    {
        private string _todo;
        private bool _completed { get; set; } = false;

        private int _id = 0;

        public TodoItem(string todo)
        {
            _todo = todo;
            _id = Counter.GetNextValue();
        }

        public int Id => _id;

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
