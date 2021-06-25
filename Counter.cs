using System;
using System.Collections.Generic;
using System.Text;

namespace TodoCLI
{
    public static class Counter
    {
        private static int _count;
        private static int _totalCount;

        public static int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;

            return _count;
        }

        public static void ResetTodo()
        {
            _count = 0;
        }

        //public static int TotalCount => _totalCount;
    }
}
