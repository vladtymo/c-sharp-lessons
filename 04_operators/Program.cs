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