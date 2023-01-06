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
