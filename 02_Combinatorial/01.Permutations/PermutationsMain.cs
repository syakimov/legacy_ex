namespace _01.Permutations
{
    using System;
    using System.Linq;

    public class PermutationsMain
    {
        private static int permutationsCount;

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Range(1, n).ToArray();
            int index = 0;
           
            FindPermutations(array, index);

            Console.WriteLine($"Total permutations: {permutationsCount}");
        }

        private static void FindPermutations(int[] array, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                permutationsCount++;
            }
            else
            {
                for (int k = index; k < array.Length; k++)
                {
                    Swap(array, index, k);
                    FindPermutations(array, index + 1);
                    Swap(array, k, index);
                }
            }
        }

        private static void Swap(int[] array, int index, int i)
        {
            if (i == index)
            {
                return;
            }

            int oldValue = array[index];
            array[index] = array[i];
            array[i] = oldValue;
        }
    }
}
