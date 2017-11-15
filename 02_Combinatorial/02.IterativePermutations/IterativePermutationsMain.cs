namespace _02.IterativePermutations
{
    using System;
    using System.Linq;

    public class IterativePermutationsMain
    {
        private static int permutationsCount = 1;

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayToPermutate = Enumerable.Range(1, n).ToArray();
            int[] weights = new int[arrayToPermutate.Length];

            int index = 1;

            Console.WriteLine(string.Join(", ", arrayToPermutate));

            while (index < arrayToPermutate.Length)
            {
                if (weights[index] < index)
                {
                    int lowerIndex = index % 2 * weights[index];

                    Swap(arrayToPermutate, index, lowerIndex);

                    Console.WriteLine(string.Join(", ", arrayToPermutate));

                    permutationsCount++;
                    weights[index]++;

                    index = 1;
                }
                else
                {
                    weights[index] = 0;
                    index++;
                }
            }

            Console.WriteLine($"Total permutations: {permutationsCount}");
        }

        private static void Swap(int[] array, int index, int j)
        {
            if (index == j)
            {
                return;
            }

            int oldValue = array[index];
            array[index] = array[j];
            array[j] = oldValue;
        }
    }
}
