// Calculator
int num1, num2;
double result;
string operation, input;

Console.WriteLine("Enter first number: ");
input = Console.ReadLine();
num1 = Convert.ToInt32(input);
Console.WriteLine("Enter operation: ");
input = Console.ReadLine();
operation = input;
Console.WriteLine("Enter second number: ");
input = Console.ReadLine();
num2 = Convert.ToInt32(input);

// Operations (+,-,/,*)
switch (operation)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Result: {num1}+{num2}={result}");
        Console.ReadKey();
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Result: {num1}-{num2}={result}");
        Console.ReadKey();
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Result: {num1}*{num2}={result}");
        Console.ReadKey();
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine($"Result: {num1}/{num2}={result}");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Invalid Operation");
        Console.ReadKey();
        break;
}