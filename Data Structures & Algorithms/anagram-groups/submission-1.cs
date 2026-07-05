public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var freq = new int[26];
            foreach (var c in word)
            {
                freq[c - 'a'] += 1;
            }
            var key = string.Join(",", freq);
            if (!dict.TryGetValue(key, out List<string>? value))
            {
                value = [];
                dict[key] = value;
            }

            value.Add(word);
        }

        return [.. dict.Values];
    }
}
