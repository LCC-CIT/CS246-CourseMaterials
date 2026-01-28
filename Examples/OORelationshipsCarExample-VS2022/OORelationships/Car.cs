namespace OORelationships;

class Car
{
    // Instance variables
    private readonly Engine gasEngine = new Engine();  // composition relationship

    // Properties
    public Person? Driver { get; set; }   // aggregation relationship
    public List<Person>? Passengers { get; set; } // aggregation relationship

    // Methods
    public int Speed
    {
        get { return gasEngine.RPM / 100; }
    }

    public virtual void Go()
    {
        gasEngine.RPM = 1000;
    }

    public virtual void Stop()
    {
        gasEngine.RPM = 0;
    }
}
