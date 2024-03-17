using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Containers;

public class LiquidContainer: Kontener, IHazardNotifier
{
    private static List<string> dangerous = new List<string>() { "fuel","radioactive" };
    public LiquidContainer(double cargoWeight, double height, double containerWeigh,
        string containerType, double maxLoad) : base(cargoWeight, height, containerWeigh, containerType, maxLoad)
    {
    }

    public virtual void Load(double weight,string cargoName)
    {
        if (InDangerous(cargoName))
        {
            if (weight+CargoWeight>MaxLoad/2)
            {
                NotifyDangerousSituation();
            }
        }
        else
        {
            if (weight+CargoWeight>MaxLoad*0.9)
            {
                NotifyDangerousSituation();
            }   
        }
    }

    private bool InDangerous(string name)
    {
        for (int i = 0; i < dangerous.Count; i++)
        {
            if (dangerous[i]==name)
            {
                return true;
            }
        }
        return false;
    }

    public virtual void Unload()
    {
        base.Unload();
        
    }

    public void getInfo()
    {
        Console.WriteLine("info about kontener");
    }

    public void NotifyDangerousSituation()
    {
        Console.WriteLine("Dangerous Cargo Situation with " + FormatNumber);
    }
}