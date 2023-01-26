// OOP - Object Oriented Programming

// Application consists with objects:
// Object has Properties and Functions

// object prototye
struct Product
{
    // properties:
    public string name;
    public double weight;
    public decimal price;
    public string color;
    public string manufactor;
    public bool isInStock;

    // functions:
    // sysntax: access return_type name() { ..code... }
    public void ShowProduct()
    {
        Console.WriteLine($"Product: {name} {color} {price}$ {manufactor}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //string[] names = new string[5] { "iPhone", "Audi", "Ball", "Table", "T-Shirt" };
        //double[] prices = new double[5] { 950, 45000, 10, 340, 120 };

        //Console.WriteLine($"First product: {names[0]} {prices[0]}");

        // object instance
        Product myPhone = new Product();
        myPhone.name = "iPhone X";
        myPhone.price = 769;
        myPhone.color = "White";
        myPhone.manufactor = "Apple";
        myPhone.weight = 128;

        Product myCar = new Product();
        myCar.name = "Note E11";
        myCar.price = 5700;
        myCar.color = "Dark Blue";
        myCar.manufactor = "Nissan";
        myCar.weight = 1350;

        Product[] angar = new Product[2] { myPhone, myCar };

        // вивід інформації про продукт
        myPhone.price += 100;
        myPhone.ShowProduct(); // виклик функції обʼєкта

        myCar.price += 100;
        myCar.ShowProduct();   // виклик функції обʼєкта
    }
}