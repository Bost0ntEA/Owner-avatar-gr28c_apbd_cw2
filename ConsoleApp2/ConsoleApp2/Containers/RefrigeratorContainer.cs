namespace ConsoleApp2.Containers;

public class RefrigeratorContainer:Kontener
{
    private double Temperature { get; set; }
    private PossibleProducts productContained;
    public RefrigeratorContainer(double cargoWeight, double height, double containerWeigh,
        string containerType, double maxLoad, PossibleProducts product,
        double temperature) : base(cargoWeight, height, containerWeigh, containerType, maxLoad)
    {
        productContained=product;
        if ((int)productContained<temperature)
        {
            throw new Exception("bad temperature to Cargo Exception ");
        }
        Temperature = temperature;
    }
    public void getInfo()
    {
        Console.WriteLine("info about kontener");
    }
    
}