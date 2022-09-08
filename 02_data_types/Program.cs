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
