// it is a line comment

/*
    block comment
*/

// -=-=-=-=-=-=-=- Console Output -=-=-=-=-=-=-=-
// object.method(parameter);
Console.WriteLine("Console IO example project.");

Console.Write("Some text with Write method!");         // without end of line
Console.WriteLine("Some text with WriteLine method!"); // with end of line

/* Escape sequences: 
 * \n - end of line
 * \t - tabulation
 * \" - "
 * \' - '
 * \\ - \
 */
Console.Write("First.\n\tSecond.\n\t\tThird.\n");
Console.WriteLine("My name is \"Vlad\"");
Console.WriteLine("Url: http:\\\\www.google.com");


// -=-=-=-=-=-=-=- Data Types -=-=-=-=-=-=-=-
/* -------------- Base types:
 * int      - integer number                (4 bytes):          10 55 -100 158686
 * short    - short integer number          (2 bytes):          10 55 -100
 * float    - number with floating point    (4 bytes):          5.5 -10.33 200.0
 * double   - number with floating point    (8 bytes):          5.5 -10.33 200.0
 * string   - character sequence            (2 bytes per char): "Hello" "How are you?" "ABC123"  "" "  "
 * char     - one character                 (2 bytes):          '?' '!' '+'
 * bool     - logic operation result        (1 bytes):          true false
 */

Console.WriteLine("ABC"); // string
Console.WriteLine('A');   // char
Console.WriteLine(3344);  // int
Console.WriteLine(false); // bool

// Ctrl + / - comment/uncomment

// -=-=-=-=-=-=-=- Variables -=-=-=-=-=-=-=-
// create variable: data_type name;
// naming: a-z A-Z 0-9 _ but can't start with digit

short currentYear;

// set data: name = value;
currentYear = 2022;

// reset data
currentYear = 1999;

// show value
Console.WriteLine(currentYear);

// initialize: type name = value;
string login = "vtymos";

Console.WriteLine(login);

// literal: F/f - float

// constants: const type name...
const float PI = 3.14F;

//PI = 3.14F; // error - can not modify constant

// -=-=-=-=-=-=-=- Console Input -=-=-=-=-=-=-=-
// ///// user name /////
Console.Write("Enter your name: ");

string name = Console.ReadLine();

//Console.Write("Hello, ");
//Console.WriteLine(name);

// string interpolation - inject variable data into string
Console.WriteLine($"Hello, {name}");

// ///// birth year /////
Console.Write("Enter birth year: ");

// convert string to int
int birthYear = int.Parse(Console.ReadLine());

Console.WriteLine($"Your birth year is {birthYear}");