# Boolean Algebra Evaluator

This is a C# console application that evaluates Boolean algebra expressions and generates truth tables for the given input. The program supports a wide range of Boolean operators, allowing users to analyze the behavior of logical expressions. 

### Features:
- **Boolean Expression Evaluation**: Supports expressions with variables (e.g., A, B, C) and logical operators like `AND`, `OR`, `XOR`, `IMPLIES`, `EQUALS`, `NAND`, and `NOR`.
- **Automatic Variable Extraction**: The program automatically identifies and extracts the variables from the entered Boolean expression.
- **Truth Table Generation**: For each Boolean expression, a truth table is generated, showing all possible combinations of the variables and the corresponding results of the expression.
- **Customizable Operators**: Easily add or modify operators to extend the functionality.

### Operators Supported:
- **AND**: Logical AND (`A AND B`)
- **OR**: Logical OR (`A OR B`)
- **IMPLIES**: Logical implication (`A IMPLIES B`)
- **EQUALS**: Logical equivalence (`A EQUALS B`)
- **NAND**: Logical NAND (`A NAND B`)
- **NOR**: Logical NOR (`A NOR B`)
- **XOR**: Logical XOR (`A XOR B`)

### Example Usage:
1. Run the program in a C# environment.
2. When prompted, enter a Boolean expression such as `A AND B OR C`.
3. The program will automatically extract the variables (`A`, `B`, `C`) and generate the corresponding truth table.

### Installation:
1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/yourusername/BooleanAlgebraEvaluator.git
    ```
2. Open the solution file in Visual Studio or any other C# compatible IDE.
3. Build and run the project.

### Requirements:
- .NET Core or .NET Framework
- Visual Studio or any C# compatible IDE

### Example Input:
```text
Enter a Boolean Expression (e.g., A AND B OR C): A AND B OR C
```

### Example Output (for the expression `A AND B OR C`):
```text
| A | B | C | A AND B OR C |
----------------------------
| 0 | 0 | 0 | 0 |
| 0 | 0 | 1 | 1 |
| 0 | 1 | 0 | 0 |
| 0 | 1 | 1 | 1 |
| 1 | 0 | 0 | 0 |
| 1 | 0 | 1 | 1 |
| 1 | 1 | 0 | 1 |
| 1 | 1 | 1 | 1 |
```

### Dislaimer:
This project is a demonstration and should not be considered a robust implementation. It was made solely for experimentation and enjoyment, without any guarantee of performance or quality.
