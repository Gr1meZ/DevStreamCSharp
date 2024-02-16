using System.Text;

namespace DevStream.Tasks.Task4;

public class Task4
{
    public static string ReverseString(string s)
    {
        var builder = new StringBuilder();
        for (var i = s.Length - 1; i >= 0; i--)
        {
            builder.Append(s[i]);
        }

        return builder.ToString();
    }

    public static bool IsPalindrome(string s) => s == ReverseString(s);

    public static IEnumerable<int> MissingElements(int[] arr)
    {
        for (var number = arr[0] + 1; number < arr[^1]; number++)
        {
            var value = Array.IndexOf(arr, number);
            if (value == -1)
                yield return number;
        }
    }
}