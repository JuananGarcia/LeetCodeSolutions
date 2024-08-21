public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        int op = 0;

        foreach(var i in tokens)
        {
            if (int.TryParse(i, out int num)) stack.Push(num);
            else
            {
                op = stack.Pop();
                switch(i) 
                {
                    case "/":
                        op = stack.Pop() / op;
                        break;
                    case "*":
                        op = stack.Pop() * op;
                        break;
                    case "+":
                        op = stack.Pop() + op;
                        break;
                    case "-":
                        op = stack.Pop() - op;
                        break;
                }

                stack.Push(op);
            }
        }

        return stack.Pop();
    }
}