public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sMap[s[i]] = sMap.GetValueOrDefault(s[i], 0) + 1;
            tMap[t[i]] = tMap.GetValueOrDefault(t[i], 0) + 1;
        }
            
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
