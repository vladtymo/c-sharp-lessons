// create array template: type[] name = new type[size];

// create array of prices
double[] prices = new double[10];

// set element value
prices[0] = 1300.5;
prices[1] = 7800.9;
prices[2] = 999;

prices[7] = 550090.45;

//Console.WriteLine($"First product price = {prices[0]}");
//Console.WriteLine($"Last product price = {prices[9]}");

// show all prices

//for (int i = 0; i < 10; ++i)
//{
//    Console.WriteLine($"Product {i + 1} price = {prices[i]}");
//}

// Завдання: зберегти та відобразити список кольорів

// ініціалізація масива
//string[] colors = new string[5] { "red", "green", "blue", "gray", "white" };

//Console.Write("Enter color: ");
//colors[0] = Console.ReadLine();

//Console.WriteLine("Colors: " + colors.Length);

//// indexes: 0 ... 4

//for (int index = 0; index < colors.Length; ++index)
//{
//    Console.Write($"{colors[index]}, ");
//}

// Завдання: обрахувати загальну ціну всіх товарів
double[] costs = new double[8] { 100, 55, 120.5, 1000, 12, 99, 300, 550 };

Console.Write("Costs: ");

float summ = 0;

for (int i = 0; i < costs.Length; ++i)
{
    costs[i]
    Console.Write($"{costs[i]} ");
}