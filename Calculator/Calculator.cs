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
if (operation == "+")
{
    result = num1 + num2;
    Console.Write("Result: ");
    Console.WriteLine(result);
    Console.ReadKey();
}
else if (operation == "-") 
{
    result = num1 - num2;
    Console.Write("Result: ");
    Console.WriteLine(result);
    Console.ReadKey();
}
else if (operation == "*")
{
    result = num1 * num2;
    Console.Write("Result: ");
    Console.WriteLine(result);
    Console.ReadKey();
}
else if (operation == "/")
{
    result = num1 / num2;
    Console.Write("Result: ");
    Console.WriteLine(result);
    Console.ReadKey();
}
else
{
    Console.WriteLine("Invalid operation");
    Console.ReadKey();
}
