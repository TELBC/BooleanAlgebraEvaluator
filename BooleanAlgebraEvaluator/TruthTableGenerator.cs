public class TruthTableGenerator
{
    public void GenerateTruthTable(string expression, List<string> variables)
    {
        var parser = new ExpressionParser();
        var evaluator = new ExpressionEvaluator();
        List<List<bool>> combinations = GenerateCombinations(variables.Count);
        Console.WriteLine("| " + string.Join(" | ", variables) + " | " + expression + " |");
        Console.WriteLine(new string('-', (variables.Count + 1) * 10));

        foreach (var combination in combinations)
        {
            var valuesDict = variables.Zip(combination, (v, val) => new { v, val }).ToDictionary(x => x.v, x => x.val);
            var postfix = parser.ConvertToPostfix(expression, variables);
            bool result = evaluator.EvaluatePostfix(postfix, valuesDict);

            Console.WriteLine("| " + string.Join(" | ", combination.Select(v => v ? "1" : "0")) + " | " + (result ? "1" : "0") + " |");
        }
    }

    private List<List<bool>> GenerateCombinations(int variableCount)
    {
        int rows = 1 << variableCount;
        var combinations = new List<List<bool>>();
        for (int i = 0; i < rows; i++)
        {
            var row = new List<bool>();
            for (int j = 0; j < variableCount; j++)
                row.Add((i & (1 << (variableCount - j - 1))) != 0);
            combinations.Add(row);
        }
        return combinations;
    }
}