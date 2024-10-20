// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old are you?");
int  age = int.Parse(Console.ReadLine());


if (age >= 18)
{
    Console.WriteLine("You can go to party.");
    
} else if  (age >= 13)
{
    Console.WriteLine("Are you with your parents? Yes or No?");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "Yes" || isWithParentsString == "yes")
    {
        Console.WriteLine("Go to party with your parents.");
    } else
    {
        Console.WriteLine("You can't go to party.");
    }
    
} else
{
    Console.WriteLine("You can't go to party.");
}

Console.ReadLine();