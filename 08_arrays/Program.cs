// create array template: type[] name = new type[size];

// create array of prices
double[] prices = new double[1000];

// set element value
prices[0] = 1300.5;
prices[1] = 7800.9;
prices[2] = 999;

prices[7] = 550090.45;

Console.WriteLine($"First product price = {prices[0]}");
Console.WriteLine($"Last product price = {prices[9]}");

// show all prices

for (int i = 0; i < 1000; ++i)
{
    Console.WriteLine($"Product {i+1} price = {prices[i]}");
}



