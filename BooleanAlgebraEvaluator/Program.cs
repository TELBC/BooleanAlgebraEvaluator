using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the BooleanAlgebraEvaluator program!");
        Console.WriteLine("This program evaluates Boolean algebra expressions and is a PoC");
        Console.WriteLine("Created by: TELBC");
        Console.WriteLine();
        Console.WriteLine("How it works:");
        Console.WriteLine("1. Enter a Boolean expression using variables (e.g., A AND B OR C).");
        Console.WriteLine("2. The program will automatically extract the variables and generate a truth table.");
        Console.WriteLine("3. It supports common Boolean operators like AND, OR, XOR, IMPLIES, EQUALS, NAND, and NOR.");
        Console.WriteLine();
        Console.WriteLine("Accepted Terms:");
        Console.WriteLine("- Variables: Single uppercase letters (A, B, C, etc.)");
        Console.WriteLine("- Operators: AND, OR, IMPLIES, EQUALS, NAND, NOR, XOR");
        Console.WriteLine();
        Console.Write("Enter a Boolean Expression (e.g., A AND B OR C): ");
        string expression = Console.ReadLine().ToUpper();
        List<string> variables = ExtractVariables(expression);
        var truthTableGenerator = new TruthTableGenerator();
        truthTableGenerator.GenerateTruthTable(expression, variables);
    }

    private static List<string> ExtractVariables(string expression)
    {
        var operators = OperatorManager.Operators.Keys.ToHashSet();
        return Regex.Matches(expression, "\\b[A-Z]+\\b")
            .Select(m => m.Value)
            .Where(variable => !operators.Contains(variable))
            .Distinct()
            .OrderBy(v => v)
            .ToList();
    }
}
