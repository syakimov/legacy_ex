namespace _05.PermutationsWithRepetition
{
    using System;

    public class PermutationsMain
    {
        public static void Main(string[] args)
        {
            Console.Write("s =");
            string[] sequence = Console.ReadLine().Split(new[] { '{', '}', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(sequence);
            int index = 0;
            int end = sequence.Length;

            Permutate(sequence, index, end);
        }

        private static void Permutate(string[] sequence, int startIndex, int endIndex)
        {
            Console.WriteLine(string.Join(", ", sequence));

            if (startIndex < endIndex)
            {
                for (int i = endIndex - 1; i >= startIndex; i--)
                {
                    for (int j = i + 1; j < endIndex; j++)
                    {
                        if (sequence[i] != sequence[j])
                        {
                            Swap(sequence, i, j);
                            Permutate(sequence, i + 1, endIndex);
                        }
                    }

                    string tempValue = sequence[i];
                    for (int k = i; k < endIndex - 1; k++)
                    {
                        sequence[k] = sequence[k + 1];
                    }

                    sequence[endIndex - 1] = tempValue;
                }
            }
        }

        private static void Swap(string[] sequence, int firstIndex, int secondIndex)
        {
            string oldValue = sequence[firstIndex];
            sequence[firstIndex] = sequence[secondIndex];
            sequence[secondIndex] = oldValue;
        }
    }
}
