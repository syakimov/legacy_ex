using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static int stepsTaken = 0;
        static Stack<int> first;
        static Stack<int> second;
        static Stack<int> third;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            first = new Stack<int>(Enumerable.Range(1, n).Reverse());
            second = new Stack<int>();
            third = new Stack<int>();
            PrintRods();
            MoveDiscs(n, first, second, third);
        }
        private static void PrintRods()
        {
            Console.WriteLine($" 1  {string.Join(",", first.Reverse())}");
            Console.WriteLine($" 2   {string.Join(",", second.Reverse())}");
            Console.WriteLine($" 3 {string.Join(",", third.Reverse())}");
            Console.WriteLine();
        }
        private static void MoveDiscs(int n, Stack<int> first, Stack<int> second, Stack<int> third)
        {
            if (n == 1)
            {
                stepsTaken++;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk {n}");
                second.Push(first.Pop());
                PrintRods();

            }
            else
            {
                MoveDiscs(n - 1, first,third,second);
                second.Push(first.Pop());
                MoveDiscs(n - 1,third, second, first);
            }

        }
    }
}
