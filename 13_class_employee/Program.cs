namespace _13_class_employee;

class Employee
{
    // fields
    public string name;
    public string surname;
    public string level; // TODO: create enum { }
    public bool isDelivery;
    public decimal salary;
    public DateTime hireDate;

    public void Show()
    {
        Console.WriteLine($"Employee {name} {surname} has {level} level.");
        //if (isDelivery)
        //{
        //    Console.WriteLine("Employee is delivery.");
        //}
        //else
        //{
        //    Console.WriteLine("Employee is not delivery.");
        //}

        // thernary operator: (condition ? value_if_true : value_if_false
        Console.WriteLine($"Employee is {(isDelivery ? "delivery" : "not delivery")}.");
    }
    public void ShowExperience()
    {
        // DateTime.Now - current time
        Console.WriteLine($"Employee has {DateTime.Now.Year - hireDate.Year} years of experience.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee();
        emp1.name = "Igor";
        emp1.surname = "Martyn";
        emp1.salary = 3200;
        emp1.level = "Seniour";
        emp1.hireDate = new DateTime(2012, 3, 25);
        emp1.isDelivery = true;

        emp1.Show();
        emp1.ShowExperience();
    }
}
