using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class GroupPermutations
{
    static Dictionary<char, int> letters;
    static StringBuilder result = new StringBuilder();

    static void Main()
    {
        letters = new Dictionary<char, int>();
        foreach (var ch in Console.ReadLine().ToCharArray())
        {
            if (!letters.ContainsKey(ch))
            {
                letters.Add(ch, 0);
            }
            letters[ch]++;
        }

        GeneratePermutations(letters.Select(x => x.Key).ToArray());
        Console.WriteLine(result.ToString().Trim());
    }

    static void GeneratePermutations(char[] arr, int k = 0)
    {
        if (k >= arr.Length)
        {
            AppendLineToResult(arr);
        }
        else
        {
            GeneratePermutations(arr, k + 1);

            for (int i = k + 1; i < arr.Length; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                GeneratePermutations(arr, k + 1);
                Swap(ref arr[k], ref arr[i]);
            }
        }
    }

    private static void AppendLineToResult(char[] arr)
    {
        foreach (var ch in arr)
        {
            result.Append(new string(ch, letters[ch]));
        }
        result.AppendLine();
    }

    static void Swap<T>(ref T first, ref T second)
    {
        T oldFirst = first;
        first = second;
        second = oldFirst;
    }
}
