public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int[] final = new int[k];

        foreach(var num in nums) 
        {
            if(result.ContainsKey(num))
            {
                result[num]++;
                
            }
            else
            {
                result[num] = 1;
            }

        }

        int i = 0;
        int j = 1;
        foreach (var num in result.OrderByDescending(key => key.Value))
        {
            final[i] = num.Key;

            if (j == k ) return final;
            j++;
            i++;
        }

        return null;
    }
}