using System.Text.RegularExpressions;

public class ExpressionParser
{
    public List<string> ConvertToPostfix(string expression, List<string> variables)
    {
        Stack<string> stack = new();
        List<string> output = new();
        var tokens = Regex.Split(expression, "(\\s+|\\(|\\)|AND|OR|IMPLIES|EQUALS|NAND|NOR|XOR|!)")
            .Where(t => !string.IsNullOrWhiteSpace(t)).ToList();

        foreach (var token in tokens)
        {
            if (variables.Contains(token))
            {
                output.Add(token);
            }
            else if (token == "(")
            {
                stack.Push(token);
            }
            else if (token == ")")
            {
                while (stack.Count > 0 && stack.Peek() != "(")
                {
                    output.Add(stack.Pop());
                }
                stack.Pop();
            }
            else if (OperatorManager.Operators.ContainsKey(token) || token == "!")
            {
                while (stack.Count > 0 && OperatorManager.Precedence.ContainsKey(stack.Peek()) && OperatorManager.Precedence[stack.Peek()] >= OperatorManager.Precedence[token])
                {
                    output.Add(stack.Pop());
                }
                stack.Push(token);
            }
        }

        while (stack.Count > 0)
            output.Add(stack.Pop());

        return output;
    }
}