// The class
public class Car
{
    // Class members
    public string model;        // field
    public string color;        // field
    public int maxSpeed;        // field
    public int year;        // field

    public void fullThrottle()   // method
    {
        Console.WriteLine(model + " is going as fast as it can!");
    }
}


public class car
{
    public static void Main(string[] args)
    {
        Car ford = new Car();
        ford.model = "Mustang";
        ford.color = "red";
        ford.year = 1969;

        Car honda = new Car();
        honda.model = "Brio";
        honda.color = "orange";
        honda.year = 2019;

        Console.WriteLine(ford.model);

        Console.WriteLine(honda.model);
        honda.fullThrottle();
  

    Console.ReadKey();
    }
}

