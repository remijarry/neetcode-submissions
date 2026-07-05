public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        foreach (var c in s)
            sMap[c] = sMap.GetValueOrDefault(c, 0) + 1;

        foreach (var c in t)
            tMap[c] = tMap.GetValueOrDefault(c, 0) + 1;

        foreach (var val in sMap)
        {
            if (!tMap.ContainsKey(val.Key))
                return false;
            if (val.Value != tMap[val.Key])
                return false;
        }

        return true;
    }
}
