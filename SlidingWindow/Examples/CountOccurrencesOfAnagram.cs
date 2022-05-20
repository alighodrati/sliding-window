// Count Occurrences of Anagram
// Given a word and a text, return the count of occurrences of the anagrams of the word in the text.
class CountOccurrencesOfAnagram
{
    internal static int CountAnagram(string text, string word)
    {
        var w = word.Length;
        var count = 0;
        var ana = "";
        var d = new Dictionary<string, int>();
        foreach (var i in Enumerable.Range(0, w))
        {
            ana += text[i];
        }
        if (IsAnagram(ana, word))
        {
            count += 1;
        }
        foreach (var i in Enumerable.Range(1, text.Length - 1))
        {
            ana = ana[1..] + text[i];
            if (!d.Any(a => a.Key == ana) && IsAnagram(ana, word))
            {
                count += 1;
                d[ana] = 0;
            }
            d[ana] = 0;
        }
        return count;
    }

    private static bool IsAnagram(string s, string word)
    {
        if (s.Length != word.Length)
        {
            return false;
        }
        var d = new int[26];
        foreach (var c in s)
        {
            d[c - 'a'] = 1;
        }
        foreach (var c in word)
        {
            if (d[c - 'a'] == 0)
            {
                return false;
            }
        }
        return true;
    }
}
