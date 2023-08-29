public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
                	Dictionary<string, List<string>> ana = new Dictionary<string, List<string>>();

        foreach(var anagram in strs )
        {
            var aArray = anagram.ToCharArray(); 
            Array.Sort(aArray);
            var sorted = new string(aArray);

            if (ana.ContainsKey(sorted))
            {
                ana[sorted].Add(anagram);
            }
            else
            {
                ana.Add(sorted, new List<string>(){anagram});
            }
        }

        //Select the list for any element in ana and transform to List for return the result.
        IList<IList<string>> anagrams = ana.Select(x=>(IList<string>)(x.Value)).ToList();
        return anagrams;
    }
}