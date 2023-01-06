Console.Write("Enter your mark: ");
int mark = int.Parse(Console.ReadLine());

if (mark == 1)
{
    Console.WriteLine("very bad!");
}
else if (mark == 2)
{
    Console.WriteLine("bad!");
}
else if (mark == 3)
{
    Console.WriteLine("normal!");
}
else if (mark == 4)
{
    Console.WriteLine("good!");
}
else if (mark == 5)
{
    Console.WriteLine("very good!");
}
else
{
    Console.WriteLine("Mark is incorect!");
}

// switch
switch (mark)
{
    case 1: Console.WriteLine("very bad!"); break;
    case 2: Console.WriteLine("bad!"); break;
    case 3: Console.WriteLine("normal!"); break;
    case 4: Console.WriteLine("good!"); break;
    case 5: Console.WriteLine("very good!"); break;
    default: Console.WriteLine("Mark is incorect!"); break;
}

// show the opposite direction (north, south, east, west)
Console.WriteLine("Enter the direction: ");
string direction = Console.ReadLine();

switch(direction)
{
    case "north": Console.WriteLine("Go South!"); break;
    case "south": Console.WriteLine("Go North!"); break;
    case "east": Console.WriteLine("Go West!"); break;
    case "west": Console.WriteLine("Go East!"); break;
    default: Console.WriteLine("You entered invalid direction!"); break;
}