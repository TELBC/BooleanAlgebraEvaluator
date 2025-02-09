public class ExpressionEvaluator
{
    public bool EvaluatePostfix(List<string> postfix, Dictionary<string, bool> values)
    {
        Stack<bool> stack = new();

        foreach (var token in postfix)
        {
            if (values.ContainsKey(token))
            {
                stack.Push(values[token]);
            }
            else if (token == "!")
            {
                stack.Push(!stack.Pop());
            }
            else if (OperatorManager.Operators.ContainsKey(token))
            {
                bool b = stack.Pop();
                bool a = stack.Pop();
                stack.Push(OperatorManager.Operators[token](a, b));
            }
        }
        return stack.Pop();
    }
}