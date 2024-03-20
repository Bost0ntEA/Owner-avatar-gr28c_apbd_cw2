using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Containers;

public abstract class Kontener: IContainer
{
    protected double CargoWeight;
    protected double Height;
    protected double ContainerWeight;
    protected double Depth;
    public string FormatNumber { get; set; }
    protected double MaxLoad;
    private static int CurrentContainer;
    public double CargoWight { get;  set; }
    protected Kontener(double cargoWeight,double height,double containerWeigh, string containerType, double maxLoad)
    {
        if (cargoWeight>MaxLoad)
        {
            throw new OverfillException();
        }

        Height = height;
        CargoWight = cargoWeight;
        ContainerWeight = containerWeigh;
        FormatNumber = "KON-" +  containerType + "-" + ++CurrentContainer;
        CurrentContainer++;
    }
    public void Load(double weight)
    {
        if (weight+CargoWeight>MaxLoad)
        {
            throw new OverfillException();
        }
    }
    public void Unload()
    {
        CargoWight = 0;
        Console.WriteLine("Wyładowano ładunek. ");
    }

    public void GetInfo()
    {
        Console.WriteLine("info about kontener " + FormatNumber);
    }
    
}

