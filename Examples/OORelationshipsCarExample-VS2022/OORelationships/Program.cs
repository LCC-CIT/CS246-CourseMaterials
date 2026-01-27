namespace OORelationships;

class Program
{
    static void Main()
    {
        HybridCar prius = new HybridCar();
        prius.Driver = new Person { Name = "Mario" };
        prius.Go();

        Console.WriteLine("Your car is being driven by {0} at {1} MPH",
            prius.Driver.Name, prius.Speed);
    }
}

