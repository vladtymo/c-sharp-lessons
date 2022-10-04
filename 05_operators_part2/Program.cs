// -=-=-=-=-=-=-=- Combine Logic Operators -=-=-=-=-=-=-=-

// [ Ctrl + / ] - comment/uncomment

Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());

// check in range 20...50
// [out of the range] ... 20 ... [in the range] ... 50 ... [out of the range]

if (number >= 20)
{
    if (number <= 50)
    {
        Console.WriteLine("Number is in the range!");
    }
    else
    {
        Console.WriteLine("Number is out of the range!");
    }
}
else
{
    Console.WriteLine("Number is out of the range!");
}

// && - logic AND   true = true + true
// || - logic OR    true = true + false / false + true

if (number >= 20 && number <= 50)
{
    Console.WriteLine("Number is in the range!");
}
else
{
    Console.WriteLine("Number is out of the range!");
}

// check if the number multiple by 3 or 7

if (number % 3 == 0 || number % 7 == 0)
{
    Console.WriteLine("Number is multiple by 3 or 7!");
}

// check if number is negative or positive in the range from 100 to 200

if (number < 0 || (number >= 100 && number <= 200))
{
    Console.WriteLine("Number is negative or in the range!");
}
else Console.WriteLine("Invalid number!");