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

Console.WriteLine("Enter line length: ");
int length = int.Parse(Console.ReadLine()); // 7

// length - довжина лінії
// counter - кількість виконаних ітерацій цикла

for (int counter = 0; counter < length; ++counter)
{
    Console.Write("#");
}
