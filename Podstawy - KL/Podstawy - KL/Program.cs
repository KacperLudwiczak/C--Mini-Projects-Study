// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// declare a string variable
string myFriendsName;
// assign a value to the myFriendsName variable
myFriendsName = "Kevin";

// use the variable
Console.WriteLine(myFriendsName);

// overwriting the variable value
myFriendsName = "John";
Console.WriteLine(myFriendsName);

// Referency Type
string myName = "Kacper";

// Value Types
int  myIndex = 13;
double pi = 3,14

// One element value
char dollar ="$";

// prints out whatever is in side of ()
Console.WriteLine("Enter something");

// takes user input and stores it
// variable with name "userInput" and the data type "string"
// strings are used for text
string? userInput = Console.ReadLine();

// we add two strings and writing them in console
Console.WriteLine("You entered " + userInput);


static void Main(string[] args)
{
    Method();
}

/// <summary> 
/// This is a method
/// </summary>
static void Method()
{
    // code
}

// Interpolation
Console.WriteLine($"My index {myIndex}");
// Concatination
Console.WriteLine("My index " + myIndex);
// Formatting
Console.WriteLine("My index {0} and the Pi {1}", myIndex, pi);

// Conversions
string numberString = "123";
int stringToNumber = int.Parse(numberString);

string boolString = "true";
bool stringToBool = bool.Parse(boolString);
bool stringToBool2 = Convert.ToBoolean(boolString);
Console.WriteLine("stringToBool " + stringToBool);
Console.WriteLine("stringToBool2 " + stringToBool2);

// Implicitely typed variable
var myImplicitelyString = "myImplicitelyVariable";
var myImplicitelyNumber = 13;


// Delete unnecessary information in console
Console.ReadKey();

// Operators 
int num1 = 15;
int num2 = 3;

Console.WriteLine("Addition " + (num1 + num2)); 
Console.WriteLine("Subtraction " + (num1 - num2));
Console.WriteLine("Multiplication " + (num1 * num2));
Console.WriteLine("Division " + (num1 / num2));

// Special characters
string textWithSpecialCharacter = "This is a \"string\".\n New line.";
Console.WriteLine(textWithSpecialCharacter);

// Boolean datatype
bool isTrue = true;
bool isFalse = false;

// If statement
if (isFalse)
{
    Console.WriteLine("It is false.");
}
if (isTrue)
{
    Console.WriteLine("It is true.");
}

int myNumber = 5;
if (myNumber == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal.");
} else
{
    Console.WriteLine("Numbers are not equal.");
}

// Logical operators:
// AND -> &&
// OR -> ||
// NOT -> !

// Variants of OR:
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false

// Variants of AND:
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false

// Switch statement
int month = 3;
string monthName 
switch (month)
{
  case 1:
        monthName = "January";
        break;
  case 2:
        monthName = "February";
        break;
  default:
        monthName = "No month";
        break;
}

// Creating an instance of the Random Class
Random random = new Random();
// This will give us a random number between 1 and 10
int randomNumber = random.Next(1, 11);


//Braces({ }) -Used to define the scope or block of code, such as methods, loops, conditionals, and class definitions.

//Parentheses(( )) - Used for method calls and declarations, controlling order of operations in expressions, and surrounding conditions in control structures like if, for, while, etc.

//Square Brackets([ ]) -Used for array type declarations and accessing array elements.Also used in attributes.

//Semicolon(;) -Used to terminate statements.

//Colon (:) -Used in conditional(ternary) operator expressions, in the context of case statements within a switch, and to denote a base class or interfaces in class declarations.

//Comma(,) - Used to separate items in a list, such as parameters in method declarations, or variables in declarations.

//Period (.) -Used to access members of a class or namespace, such as methods or properties.

//Question Mark(?) - Used in nullable type declarations and the null-conditional operators.Also part of the conditional (ternary) operator.

//Plus (+) - Used as an arithmetic operator and to concatenate strings.Also used to denote unary plus or to define overloaded operators.

//Minus (-``) - Used as an arithmetic operator, to indicate a negative number, or to define overloaded operators.

//Asterisk (*``) - Used as an arithmetic operator for multiplication, to denote pointer types, or to define overloaded operators.

//Slash (/) - Used as an arithmetic operator for division.Also starts comments (// for single-line comments, /* */ for multi-line comments).

//Percentage (%) - Used as the modulus operator.

//Ampersand (&) - Used for the 'address-of' operator in unsafe code, logical AND, and bitwise AND.Also used in method signatures to indicate a reference parameter.

//Pipe (|) - Used for logical OR and bitwise OR.

//Caret(^) - Used for bitwise XOR.

//Exclamation Mark (!) - Used to denote logical negation.

//Tilde(~) - Used for bitwise NOT and to define destructor methods in classes.

//* Angle Brackets(`

//(< and >)** - Used in generic type definitions and methods, as well as for less than and greater than comparisons.

//Equals(=) - Used for assignment and to test equality when paired with another equals sign(i.e., ==). Also used in lambda expressions(=>).

//At Sign(@) - Used as a prefix to indicate a verbatim string literal, where escape sequences are ignored, or to use keywords as identifiers.

//Dollar Sign($) - Used to denote string interpolation, allowing variables to be embedded directly within string literals.

//Backslash(\\) - Used as an escape character in string literals.For example, \\n for a new line or \\t for a tab.

//Hash(#) - Used in preprocessor directives, such as #define, #if, #else, #endif, #region, and #endregion.