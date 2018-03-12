using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises
{
    public static class StringExercises
    {
        // Reverse string
        public static string ReverseString(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

        // First Unique Character in a String
        public static int FirstUniqChar(string s)
        {
            var frequency = new Dictionary<char, Item>();
            for (int i = 0; i < s.Length; i++) {
                if (frequency.ContainsKey(s[i])) {
                    frequency[s[i]].Count++;
                } else {
                    frequency[s[i]] = new Item { Index = i, Count = 1 };
                }
            }

            int result = int.MaxValue;
            foreach (var kvp in frequency) {
                if (kvp.Value.Count == 1 && result > kvp.Value.Index)
                    result = kvp.Value.Index;
            }

            return result == int.MaxValue ? -1 : result;
        }

        public class Item
        {
            public int Count { get; set; }
            public int Index { get; set; }
        }
    }
}
