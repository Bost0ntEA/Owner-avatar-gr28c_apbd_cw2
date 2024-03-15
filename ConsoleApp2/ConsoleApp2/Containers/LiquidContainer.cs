namespace ConsoleApp2;

public class LiquidContainer: Kontener
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
    }

    public virtual void Load(double weight)
    {
        base.Load(weight);
        
        
    }
    
}