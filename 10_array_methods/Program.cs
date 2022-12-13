int[] array = new int[] { 44, 10, 3, 10, -1, 10, 35, 120, 29 };

Console.Write("Enter value to find: ");
int value = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; ++i)
{
    if (array[i] == value)
    {
        Console.WriteLine("Your number was found!");
        break; // exit cycle
    }
}

Array.Sort(array);

Console.Write("Sorted array: ");
for (int i = 0; i < array.Length; ++i)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Array.Reverse(array);

Console.Write("Reversed array: ");
for (int i = 0; i < array.Length; ++i)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Array.Fill(array, 7, 2, 3); // fill 3 elements [2][3][4]

Console.Write("Filled array: ");
for (int i = 0; i < array.Length; ++i)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Found value: " + Array.Find(array, (item) => item % 2 != 0));

if (Array.Exists(array, (item) => item == value))
{
    Console.WriteLine("Value was found!");
}
