using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination_with_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Simulation(arr, 0, k, n);
        }

        private static void Simulation(int[] arr, int position, int k, int n)
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
                    if (position == k-1)
                    {
                        if (arr[position] < arr[position - 1])
                        {
                            break;
                        }
                    }
                    else
                    {
                        arr[position] = i;
                        if (position>0)
                        {
                            if (arr[position] < arr[position - 1])
                            {

                            }
                            else
                            {
                                Simulation(arr, position + 1, k + 1, n);
                            }
                        }
                        else
                        {
                            Simulation(arr, position + 1, k + 1, n);
                        }
                        
                    }
                }
            }
        }
    }
}
