using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Containers;

public class GasContainer: Kontener,IHazardNotifier
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight, double height, double containerWeigh,
        string containerType, double maxLoad) : base(cargoWeight, height, containerWeigh, containerType, maxLoad)
    {
    }

    public void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }

    public void NotifyDangerousSituation()
    {
        Console.WriteLine("Dangerous Cargo Situation with " + FormatNumber);
    }

    public void Load(double weight)
    {
        if (CargoWeight+weight>MaxLoad)
        {
            throw new OverfillException();
        }
        else
        {
            CargoWeight = CargoWeight + weight;
        }
    }
    public void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine(" Pressure = " + Pressure);
    }
}

