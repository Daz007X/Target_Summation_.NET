using System.Collections.Generic;

namespace target_sum
{
    class Combinations
    {
        public static List<List<int>> GenerateCombinations(int[] array, int k)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> currentCombination = new List<int>();
            GenerateCombinationsHelper(array, k, 0, currentCombination, result);
            return result;
        }

        private static void GenerateCombinationsHelper(int[] array, int k, int startIndex, List<int> currentCombination, List<List<int>> result)
        {
            if (currentCombination.Count == k)
            {
                result.Add(new List<int>(currentCombination)); // Add a copy of current combination to result
                return;
            }

            for (int i = startIndex; i < array.Length; i++)
            {
                currentCombination.Add(array[i]);
                GenerateCombinationsHelper(array, k, i + 1, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1); // Backtrack
            }

        }
    }
}
