public class CountBinarySubstrings {
    public int CountBinarySubstrings(string s)
    {
        int prevGroup = 0;
        int currGroup = 1;
        int result = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                currGroup++;
            }
            else
            {
                result += Math.Min(prevGroup, currGroup);
                prevGroup = currGroup;
                currGroup = 1;
            }
        }

        result += Math.Min(prevGroup, currGroup);
        return result;
    }
}