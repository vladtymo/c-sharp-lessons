int[] array = new int[] { 44, 10, 3, 10, -1, 10, 35, 120, 29 };

Console.Write("Enter value to find: ");
int value = int.Parse(Console.ReadLine());

//for (int i = 0; i < array.Length; ++i)
//{
//    if (array[i] == value)
//    {
//        Console.WriteLine("Your number was found!");
//        break; // exit cycle
//    }
//}

// пошук індекса елемента {value} в масиві {array}, якщо не знайдено, тоді поверне -1
if (Array.IndexOf(array, value) != -1)
{
    Console.WriteLine("Your number was found!");
}
else
{
    Console.WriteLine("Your number was not found!");
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

// заповнити масив {array} значенням 7 починаючи з індекса 2 та заповнити 3 елемента
Array.Fill(array, 7, 2, 3); // fill 3 elements [2][3][4]

Console.Write("Filled array: ");
for (int i = 0; i < array.Length; ++i)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Found value: " + Array.Find(array, (item) => item % 2 != 0));

if (Array.Exists(array, (item) => item < 0))
{
    Console.WriteLine("Negative number was found!");
}

// Завдання: створити масив та заповнити його випадковими числами
Random rnd = new Random();

int[] arr = new int[30];

for (int i = 0; i < arr.Length; ++i)
{
    arr[i] = rnd.Next(100); // generate random value from 0 to 100
    Console.Write(arr[i] + " ");
}
