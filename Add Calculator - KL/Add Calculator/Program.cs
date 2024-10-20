// See https://aka.ms/new-console-template for more information

// int myNmuber = 0;
// int myNmuber2 = 0;

double myNumber1 = 0.0;
double myNumber2 = 0.0;

Console.WriteLine("Enter a number: ");

string userInput = Console.ReadLine();
// myNumber1 = int.Parse(userInput);
myNumber1 = double.Parse(userInput);

Console.WriteLine("Enter a number: ");
userInput = Console.ReadLine();
// myNumber2 = int.Parse(userInput);
myNumber2 = double.Parse(userInput);

// int sum = myNumber1 + myNumber2;
double sum = myNumber1 + myNumber2;
sum = Math.Round(sum, 2);

// Old version of writing
// Console.WriteLine("The result of " + myNumber1 + " and " + myNumber2 + " is " + sum);

// New version of writing
Console.WriteLine($"The result of {myNumber1} and {myNumber2} is {sum}.");

Console.ReadKey();

