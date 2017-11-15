using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Simulation(arr, 0, n);
        }

        private static void Simulation(int[] arr, int position, int n)
        {
            if (position >= arr.Length)
            {
                for (int i = 0; i < position; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[position] = i;
                    Simulation(arr, position + 1, n);
                }
            }
        }
    }
}
