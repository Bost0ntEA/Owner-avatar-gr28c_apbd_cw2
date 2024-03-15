using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2;

public abstract class Kontener: IContainer
{
    protected double cargoWeight;

    public double CargoWight { get;  set; }

    protected Kontener(double cargoWeight)
    {
        CargoWight = cargoWeight;
    }

    public void Load(double weight)
    {
        if (cargoWeight>100)
        {
            throw new OverfillException();
        }
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }
}

