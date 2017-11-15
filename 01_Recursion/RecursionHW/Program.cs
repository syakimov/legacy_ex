using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 4, 3, 2, 1 };
            int[] revversed = new int[arr.Length];
            Reverse(arr, revversed, 0,arr.Length);
        }

        private static void Reverse(int[] arr, int[] revversed,int start, int length)
        {
            if (length==0)
            {
                for (int i = 0; i < revversed.Length; i++)
                {
                    Console.Write($"{revversed[i]}  ");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                revversed[start] = arr[length - 1];
                Reverse(arr, revversed, start + 1, length - 1);
            }
        }
    }
}
