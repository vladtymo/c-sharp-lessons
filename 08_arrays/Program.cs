// create array template: type[] name = new type[size];

// create array of prices
double[] prices = new double[20];

// set element value
prices[0] = 1300.5;
prices[1] = 7800.9;
prices[2] = 999;

prices[7] = 550090.45;

Console.WriteLine($"First product price = {prices[0]}");
Console.WriteLine($"Last product price = {prices[9]}");

// show all prices
for (int index = 0; index < prices.Length; ++index)
{
    Console.WriteLine($"Element = {prices[index]}");
}

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine($"Product price = {prices[0]}");
}

// Завдання: зберегти та відобразити список кольорів

// ініціалізація масива
string[] colors = new string[5] { "red", "green", "blue", "gray", "white" };

Console.Write("Enter color: ");
colors[0] = Console.ReadLine();

Console.WriteLine("Colors: " + colors.Length);

// indexes: 0 ... 4

for (int index = 0; index < colors.Length; ++index)
{
    Console.Write($"{colors[index]}, ");
}

// Завдання: обрахувати загальну ціну всіх товарів
double[] costs = new double[8] { 100.5, 55.2, 120.5, 1000, 12, 99, 300, 550 };

Console.Write("Costs: ");

// обрахунок суми елементів без використання цикла
Console.WriteLine($"Total summ: {costs[0] + costs[1] + costs[2] + costs[3] }");

// обрахунок суми елементів з використання цикла
double summ = 0;

for (int i = 0; i < costs.Length; ++i)
{
    summ += costs[i];
}

Console.WriteLine($"Total summ: {summ} UAH");

//summ += costs[0];
//summ += costs[1];
//summ += costs[2];
//summ += costs[3];
//...

for(int i = 0; i < costs.Length; ++i)
{
    if (costs[i] > 100)
    {
        Console.WriteLine(costs[i]);
    }
}