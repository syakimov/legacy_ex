using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorScheduling
{
    class Task : IComparable
    {

        public Task(int value, int deadline, int number)
        {
            this.Value = value;
            this.DeadLine = deadline;
            this.TaskNumber = number;
        }

        public int Value { get; set; }

        public int DeadLine { get; set; }

        public int TaskNumber { get; set; }

        public int CompareTo(object obj)
        {
            return this.Value.CompareTo((obj as Task).Value);
        }
    }
}
