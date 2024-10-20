// See https://aka.ms/new-console-template for more information

for(int counter =  1; counter <= 5; counter++)
{
    Console.WriteLine($"Plus counter is {counter}");
}
Console.WriteLine("\n");

for (int counter = 5; counter >= 1; counter--)
{
    Console.WriteLine($"Minus counter is {counter}");
}
Console.WriteLine("\n");

// while is a pre test loop
int whileCounter = 1;
    while(whileCounter <= 5)
{
    Console.WriteLine($"While counter is {whileCounter}");
    whileCounter++;
}
Console.WriteLine("\n");

// do while is a post test loop
int doCounter = 1;
do
{
    Console.WriteLine($"Do While counter {doCounter}");
    doCounter++;
} while (doCounter <= 5);
Console.WriteLine("\n");

for (int counter = 1; counter <= 5; counter++)
{
    Console.WriteLine($"Counter (with break) is {counter}");
    if(counter == 3)
    {
        Console.WriteLine("Break loop");
        break;
    }
}
Console.WriteLine("\n");

// declare an array
string[] myArray = new string[5];
int[] secondArray = { 246, 464, 89, 648, 3211 };

// assigned value to the array
myArray[0] = "A";
myArray[1] = "R";
myArray[2] = "R";
myArray[3] = "A";
myArray[4] = "Y";

for (int counter = 0; counter < myArray.Length; counter++)
{
    Console.WriteLine($"Array counter: {myArray[counter]}");
}
Console.WriteLine("\n");

for (int counter = 0; counter < myArray.Length; counter++)
{
    Console.WriteLine($"Second array counter: {secondArray[counter]}");
}
Console.WriteLine("\n");

foreach(string letters in myArray)
{
    Console.WriteLine($"Array with foreach counter: {letters}");
}


Console.ReadKey();
