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
    }
}
