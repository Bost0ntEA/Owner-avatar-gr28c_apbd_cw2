using ConsoleApp2.Containers;

namespace ConsoleApp2;

public class Kontenerowiec
{
    protected List<Kontener> Containers = new List<Kontener>();
    protected int maxContainers;
    protected double speed;
    protected double MaxWeightAllowed;

    public Kontenerowiec(int maxContainers, double speed, double maxWeightAllowed)
    {
        this.maxContainers = maxContainers;
        this.speed = speed;
        MaxWeightAllowed = maxWeightAllowed;
    }

    public void AddContainer(Kontener kontener)
    {
        Containers.Add(kontener);
    }
    public void AddContainer(Kontener[] kontener)
    {
        for (int i = 0; i < kontener.Length; i++)
        {
            Containers.Add(kontener[i]);
        }
    }

    public void RemoveContainer(string number)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].FormatNumber == number)
            {
                Containers.RemoveAt(i);
            }
        }
    }

    public void ChangeContainer(string number,Kontener kontener)
    {
        bool czyjest = false;
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].FormatNumber == number)
            {
                Containers.RemoveAt(i);
                czyjest = true;
            }
        }

        if (czyjest)
        {
            Containers.Add(kontener);   
        }
        else
        {
            Console.WriteLine("nie znaleziono kontenera");
        }
    }

    public void RealocateContainerToAnotherKontenerowiec(string number,Kontenerowiec kon1)
    {
        Kontener konpom = null;
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].FormatNumber == number)
            {
                konpom = Containers[i];
                Containers.RemoveAt(i);
            }
        }
        if (konpom != null)
        {
            kon1.AddContainer(konpom);   
        }
    }

    public void getInfoOfContainer(string number)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].FormatNumber == number)
            {
                
            }
        }   
    }
}
