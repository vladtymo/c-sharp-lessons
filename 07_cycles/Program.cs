// while
// do while
// for

/*
    counter = 0; - create counter
    counter++;   - condition
    counter < 5  - expression

    for (counter; condition; expression)
    {
        ...code...
    }
 */

Console.Write("Enter counter: ");
int number = int.Parse(Console.ReadLine());

for (int counter = 0; counter < number; counter++)
{
    Console.WriteLine("----------------");
    Console.WriteLine("Have a good day!");
    Console.WriteLine("----------------");
}

Console.WriteLine("End!");