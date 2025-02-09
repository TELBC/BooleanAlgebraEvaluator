public class OperatorManager
{
    public static readonly Dictionary<string, Func<bool, bool, bool>> Operators = new()
    {
        { "AND", (a, b) => a && b },
        { "OR", (a, b) => a || b },
        { "IMPLIES", (a, b) => !a || b },
        { "EQUALS", (a, b) => a == b },
        { "NAND", (a, b) => !(a && b) },
        { "NOR", (a, b) => !(a || b) },
        { "XOR", (a, b) => a ^ b }
    };

    public static readonly Dictionary<string, int> Precedence = new()
    {
        { "!", 3 },
        { "AND", 2 },
        { "NAND", 2 },
        { "NOR", 2 },
        { "XOR", 2 },
        { "OR", 1 },
        { "IMPLIES", 1 },
        { "EQUALS", 1 }
    };
}