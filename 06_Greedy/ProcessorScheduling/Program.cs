using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int numberOfTasks = int.Parse(line[1]);

            Task[] tasks = new Task[numberOfTasks];

            int maxDeadLine = 0;
            for (int i = 0; i < numberOfTasks; i++)
            {
                string[] currentLine = Console.ReadLine().Split(new[] { ' ', '-' }, 
                                        StringSplitOptions.RemoveEmptyEntries);

                int value = int.Parse(currentLine[0]);
                int deadLine = int.Parse(currentLine[1]);

                Task currentTask = new Task(value, deadLine, i + 1);

                if (currentTask.DeadLine > maxDeadLine)
                {
                    maxDeadLine = deadLine;
                }

                tasks[i] = currentTask;
            }

            BinaryHeap<Task> sorted = new BinaryHeap<Task>();

            List<int> output = new List<int>();
            int totalValue = 0;

            for (int i = maxDeadLine; i >= 1; i--)
            {
                var currentDedlineTask = tasks.Where(x => x.DeadLine == i);

                foreach (var task in currentDedlineTask)
                {
                    sorted.Insert(task);
                }

                var taskToProces = sorted.ExtractMax();
                totalValue += taskToProces.Value;
                output.Add(taskToProces.TaskNumber);
            }

            output.Reverse();

            Console.WriteLine("Optimal schedule: {0}", string.Join(" -> ", output));
            Console.WriteLine("Total value: {0}", totalValue);
        }
    }
}
