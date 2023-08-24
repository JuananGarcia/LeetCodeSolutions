public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var map = new HashSet<int>();

        foreach (var i in nums)
        {
            if (map.Contains(i)) return true;
            map.Add(i);
        }

        return false;
    }
}