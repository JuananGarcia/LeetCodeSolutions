public class Solution {
    public bool IsValid(string s) {
        
        stackalloc<char> endings = new Stack<char>();

        foreach (var curr in s)
        {
            switch(curr)
            {
                case('('):
                    endings.Push(')');
                    break;
                case('['):
                    endings.Push(']');
                    break;
                case('{'):
                    endings.Push('}');
                case(')'):
                case(']'):
                case('}'):
                    if (endings.Count == 0 || endings.Pop() != curr) return false;
                    break;
            }
        }

        return endings.Count == 0;

    }
}