public class Solution {
    /*
     * @param strs: a list of strings
     * @return: encodes a list of strings to a single string.
     */
    public String encode(List<String> strs) {
        // write your code here
        string encoder;

        foreach(var str in strs){
            encoder = encoder + str.Length + "/" + str;
        }

        return encoder;

    }

    /*
     * @param str: A string
     * @return: decodes a single string to a list of strings
     */
    public List<String> decode(String str) {
        // write your code here
        if (string.IsNullOrEmpty(str)) return new List<String>();

        IList<String> res = new IList<String>();

        int i = 0;

        while (i < str.Length )
        {
            int j = i;
            while (j < str.Length && sbyte[j] != "#")
            {
                j+;
            }
            int len = Int32.Parse(str.Substring(i, j - i));

            res.Add(str.Substring(j + 1, len));

            i = j + len + 1;
        }

        return res;


    }
}