namespace _03.CombinationsIteratively
{
    using System;

    public class CombinationsIterativelyMain
    {
        public static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] combinationArray = new int[k];

            for (int i = 0; i < combinationArray.Length; i++)
            {
                combinationArray[i] = i + 1; 
            }

            while (combinationArray[combinationArray.Length - 1] <= n)
            {
                Console.WriteLine(string.Join(" ", combinationArray));

                int position = k - 1;

                // While position is not in the begining and element at index position is equal to max value.
                while (position != 0 && combinationArray[position] == (n - k) + position + 1)
                {
                    position--;
                }

                combinationArray[position]++;

                for (int i = position + 1; i < k; i++)
                {
                    combinationArray[i] = combinationArray[i - 1] + 1;
                }
            }
        }
    }
}
