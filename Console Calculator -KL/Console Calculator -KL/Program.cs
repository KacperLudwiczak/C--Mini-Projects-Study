// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter first number: ");
int userNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int userNumber2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose operation (+, -, *, /): ");
char operation = Console.ReadLine()[0];

if (operation == '+')
{
    int sum = userNumber1 + userNumber2;
    Console.WriteLine($"Sum of {userNumber1} and {userNumber2} is {sum}");
}
else if (operation == '-')
{
    int subtraction = userNumber1 - userNumber2;
    Console.WriteLine($"Subtraction of {userNumber1} and {userNumber2} is {subtraction}");
}
else if (operation == '*')
{
    int multiplication = userNumber1 * userNumber2;
    Console.WriteLine($"Multiplication of {userNumber1} and {userNumber2} is {multiplication}");
}
else if (operation == '/')
{
    if (userNumber2 != 0)
    {
        double division = (double)userNumber1 / userNumber2;
        Console.WriteLine($"Division of {userNumber1} and {userNumber2} is {division}");
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}

Console.ReadKey();