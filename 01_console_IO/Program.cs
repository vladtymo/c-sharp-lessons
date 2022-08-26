// it is a line comment

/*
    block comment
*/

// -=-=-=-=-=-=-=- Console Output -=-=-=-=-=-=-=-
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
 * string   - character sequence            (2 bytes per char): "Hello" "How are you?" "" "  "
 * char     - one character                 (2 bytes):          '?' '!' '+'
 * bool     - logic operation result        (1 bytes):          true false
 */

Console.WriteLine("ABC");
Console.WriteLine('A');

// -=-=-=-=-=-=-=- Console Input -=-=-=-=-=-=-=-
// type name = value;
string login = "vtymos";

string text = Console.ReadLine();
