// See https://aka.ms/new-console-template for more information

// Methods are structured like this:
// Modifer Type Name(Parameters) {
// Code Block
// }

void MyFirstMethod()
{
    Console.WriteLine("My first method was callled");
}

MyFirstMethod();
MyFirstMethod();
MyFirstMethod();

void MethodWithParameters(string myString)
{
    Console.WriteLine($"The Parameter is {myString}");
}

string secondItem = "Second";

MethodWithParameters("First");
MethodWithParameters(secondItem);
MethodWithParameters("Third");

void AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    Console.WriteLine($"Result of adding {value1} and {value2} is {result}");
}

AddTwoValues(5, 6);
AddTwoValues(8, 35);
AddTwoValues(52, 5);

int AddTwoValuesSecond(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}

int myAddResult = AddTwoValuesSecond(5, 8);
Console.WriteLine($"Result of second adding example is {myAddResult}");

Console.ReadKey();