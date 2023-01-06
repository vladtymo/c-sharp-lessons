// -=-=-=-=-=-=-=- Arifmetic Operators -=-=-=-=-=-=-=-
/*
    + (A + B): 10 + 3 = 13
    - (A - B): 10 - 3 = 7
    * (A * B): 10 * 3 = 30
    / (A / B): 10 / 3 = 3.3333...
    % (A % B): 10 % 3 = 1
*/

float a = 5;
float b = 2;

Console.WriteLine($"a + b: {a} + {b} = {a + b}");
Console.WriteLine($"a - b: {a} - {b} = {a - b}");
Console.WriteLine($"a * b: {a} * {b} = {a * b}");
Console.WriteLine($"a / b: {a} / {b} = {a / b}");
Console.WriteLine($"a % b: {a} % {b} = {a % b}");

int result = (10 + 5) * 2; // 30

Console.WriteLine($"Result: {result}");

// завдання: розробити конвертер величин з днів в робочі години
Console.Write("Enter days: ");
int days = int.Parse(Console.ReadLine());

// naming convension: camelCaseConvension
const short workingHoursPerDay = 8;

Console.WriteLine($"Working hours: {days * workingHoursPerDay}");

const int minutesPerDay = 60 * 24;

// -=-=-=-=-=-=-=- Logic Operators -=-=-=-=-=-=-=-
/*
    >  (A > B):  5 > 10 = false
    <  (A < B):  5 < 10 = true
    >= (A >= B): 5 >= 5 = true
    <= (A <= B): 5 <= 10 = true
    == (A == B): 10 == 3 = false
    != (A != B): 10 != 3 = true
*/

a = 5;
b = 10;

Console.WriteLine($"a > b: {a} > {b} = {a > b}");
Console.WriteLine($"a < b: {a} < {b} = {a < b}");
Console.WriteLine($"a >= b: {a} >= {b} = {a >= b}");
Console.WriteLine($"a <= b: {a} <= {b} = {a <= b}");
Console.WriteLine($"a == b: {a} == {b} = {a == b}");
Console.WriteLine($"a != b: {a} != {b} = {a != b}");

// if statement
if (a < b)
{
    // code...
}

// products

int productsAvailable = 10;

Console.Write("How many products do you want to buy?\nCount: ");

int productsToBuy = int.Parse(Console.ReadLine());

// check availabilty
Console.WriteLine($"Is available: {productsToBuy <= productsAvailable}");

if (productsAvailable >= productsToBuy)
{
    Console.WriteLine("You can buy:)");
}

// can avoid scopes if we have only one operation in the if
if (productsAvailable < productsToBuy)
    Console.WriteLine("You can not buy:(");

// check rectangle is a square

Console.Write("Enter rectangle sides...\nWidth: ");
float width = float.Parse(Console.ReadLine());
Console.Write("Length: ");
float length = float.Parse(Console.ReadLine());

if (width == length)
{
    Console.WriteLine("This rectangle is a square!");
}
else
{
    Console.WriteLine("This rectangle is not a square!");
}

// check if year is leap
Console.Write("Enter a year: ");
short year = short.Parse(Console.ReadLine());

// 2000 % 4: 0
// 2001 % 4: 1
// 2002 % 4: 2
// 2003 % 4: 3
// 2004 % 4: 0
if (year % 4 == 0)
{
    Console.WriteLine($"{year} is a leap year!");
}
else
{
    Console.WriteLine($"{year} is not a leap year!");
}