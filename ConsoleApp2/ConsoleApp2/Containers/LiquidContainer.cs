namespace ConsoleApp2.Containers;

public class LiquidContainer: Kontener
{
    public LiquidContainer(double cargoWeight, double height, double containerWeigh,
        string containerType, double maxLoad) : base(cargoWeight, height, containerWeigh, containerType, maxLoad)
    {
    }

    public virtual void Load(double weight)
    {
        base.Load(weight);
    }

    public virtual void Unload()
    {
        base.Unload();
        
    }
    
}