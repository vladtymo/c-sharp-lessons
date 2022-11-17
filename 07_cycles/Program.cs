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

//Console.Write("Enter counter: ");
//int number = int.Parse(Console.ReadLine());

//for (int counter = 0; counter < number; counter++)
//{
//    Console.WriteLine("----------------");
//    Console.WriteLine("Have a good day!");
//    Console.WriteLine("----------------");
//}

//Console.WriteLine("End!");

// Приклад використання циклу для перегляду всіх значень в масиві
//string[] emailCollection = { "exmple@gmail.com", "2exmple@gmail.com", "3exmple@gmail.com", "4exmple@gmail.com", "5exmple@gmail.com" };

//for (int counter = 0; counter < 10; ++counter) // counter = 10
//{
//    // code
//    Console.WriteLine("Hello");
//}

////Console.WriteLine(emailCollection[0]);
////Console.WriteLine(emailCollection[1]);
////Console.WriteLine(emailCollection[2]);
////Console.WriteLine(emailCollection[3]);
////Console.WriteLine(emailCollection[4]);

//for (int index = 0; index <= 4; ++index)
//{
//    Console.WriteLine(emailCollection[index]);
//}


// Завдання: показати на екран лінію із символів решітка '#', довжину линії користувач вводить з клавіатури
// ######
// ###
// ###########

//Console.WriteLine("Enter line length: ");
//int length = int.Parse(Console.ReadLine()); // 7

// length - довжина лінії
// counter - кількість виконаних ітерацій цикла

//for (int counter = 0; counter < length; ++counter)
//{
//    Console.Write("#");
//}

//Console.Write(new String('#', length));

// Завдання: користувач вводить число, показати числа від 1 до введеного користувачем (1, 2, 3 ...)
Console.Write("Enter maximum number: ");
int max = int.Parse(Console.ReadLine()); // 4

//Console.Write("1, ");
//Console.Write("2, ");

// ------ using [while] cycle
int number = 1; 

while(number <= max) // true - run iteration
{
    Console.Write($"{number}, ");
    ++number; // increment number
}
Console.WriteLine("\n---------------------------");

// ------ using [for] cycle
for (int n = 1; n <= max; ++n)
{
    Console.Write($"{n}, ");
}
Console.WriteLine("\n---------------------------");

// Завдання: користувач вводить два числа - початок та кінець. Показати всі числа від початку до кінця з кроком 1 (start, ..., end)
Console.Write("Enter start number: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Enter finish number: ");
int finish = int.Parse(Console.ReadLine());

// [while]
int current = start;

while(current <= finish)
{
    Console.Write($"{current}, ");
    ++current;
}
Console.WriteLine("\n---------------------------");

// [for]
for (int c = start; c <= finish; ++c)
{
    Console.Write($"{c}, ");
}
Console.WriteLine("\n---------------------------");

// Завдання: користувач вводить сторони прямокутника і програма повинна його відобразити на екрані певним символом
// 5, 3

/*
    @@@@@
    @@@@@
    @@@@@
*/

Console.Write("Enter width: ");
int width = int.Parse(Console.ReadLine());

Console.Write("Enter height: ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; ++i)
{
    // показати рядок прямокутника
    for (int k = 0; k < width; ++k)
    {
        Console.Write('@');
    }
    // показати новий рядок
    Console.WriteLine();
}

// цикли [while] vs [do while]

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

while (age < 0 || age > 120)
{
    Console.WriteLine("Enter your age again: ");
    age = int.Parse(Console.ReadLine());
}

Console.WriteLine("Good!");

