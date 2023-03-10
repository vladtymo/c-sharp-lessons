namespace _12_methods;

class Car
{
    // properties
    public string model;
    public int year;
    public string color;
    public bool isON;

    public double currentSpeed;
    public double maxSpeed;

    // methods
    // method template: accessor return_type name(parameters) { ... }
    public void Show()
    {
        Console.WriteLine($"Car info: {model}, {year}, {color}");
    }
    public void ShowSpeed()
    {
        Console.WriteLine($"Current speed: {currentSpeed} <- {maxSpeed}km/h");
    }

    public void Start()
    {
        Console.WriteLine("Engine is starting...");
        isON = true;
    }
    public void Stop()
    {
        Console.WriteLine("Engine is stoping...");
        isON = false;
        currentSpeed = 0;
    }
    public void Boost()
    {
        if (isON == true)
        {
            currentSpeed += 15;

            // data validation: перевірка даних на коректність
            // 255 > 220
            if (currentSpeed > maxSpeed) // ящко швидкість виходить за допустиму
            {
                // current <- max: 220
                currentSpeed = maxSpeed; // обмежуємо швидкість до максимальної
            }
        }
        else Console.WriteLine("Engine shoud be started for boost!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        /* Default values:
            * numbers: 0
            * boolean: false
            * reference (classes): null
         */

        Car myCar = new Car();
        myCar.maxSpeed = 220;
        myCar.model = "Infinity FX";
        myCar.year = 2012;
        myCar.color = "Blue";

        myCar.Show();
        myCar.ShowSpeed();

        myCar.Boost();

        myCar.Start();

        for (int i = 0; i < 100008; i++)
        {
            myCar.Boost();
        }

        myCar.ShowSpeed();

        myCar.Stop();

        myCar.ShowSpeed();

        Car car2 = new Car();
        car2.model = "Passat B2";
        car2.year = 1992;
        car2.maxSpeed = 185;

        car2.Start();

        for (int i = 0; i < 100; i++)
        {
            car2.Boost();
        }

        car2.Show();
        car2.ShowSpeed();
    }
}

