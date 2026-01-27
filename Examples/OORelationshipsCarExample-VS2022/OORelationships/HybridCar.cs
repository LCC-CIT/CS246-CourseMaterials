namespace OORelationships;

class HybridCar : Car
{
    private readonly Engine electricMotor = new();   // composition relationship

    public override void Go()
    {
        electricMotor.RPM = 1000;
        base.Go();  // sets the gas engine RPM as well
    }

    public override void Stop()
    {
        electricMotor.RPM = 0;
        base.Stop();
    }
}
