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
