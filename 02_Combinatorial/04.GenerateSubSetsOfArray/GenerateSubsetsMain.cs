namespace _04.GenerateSubSetsOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenerateSubsetsMain
    {
        private static List<string> sequence;

        public static void Main(string[] args)
        {
            Console.Write("s =");
            sequence = Console.ReadLine().Split(new[] { '{', '}', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            string[] subset = new string[k];

            int index = 0;

            GenerateSubSet(subset, index, sequence[0]);
        }

        private static void GenerateSubSet(string[] subset, int index, string startValue)
        {
            if (index >= subset.Length)
            {
                Console.WriteLine(string.Join(" ", subset));
            }
            else
            {
                for (int i = sequence.IndexOf(startValue); i < sequence.Count; i++)
                {
                    subset[index] = sequence[i];
                    if (i + 1 < sequence.Count)
                    {
                        GenerateSubSet(subset, index + 1, sequence[i + 1]);
                    }           
                    else if (index != 0)
                    {
                        Console.WriteLine(string.Join(" ", subset));
                    }
                }
            }
        }
    }
}
