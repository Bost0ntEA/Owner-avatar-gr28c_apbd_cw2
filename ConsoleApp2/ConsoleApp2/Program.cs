
using ConsoleApp2;
using ConsoleApp2.Containers;

class Program
{
    static void Main(string[] args)
    {
        Kontener k1 = new GasContainer(0.0, 10.0, 100.0, "S", 150);
        Console.WriteLine(k1);
        Kontenerowiec kon1 = new Kontenerowiec(4, 20.0, 2000);
        kon1.AddContainer(k1);
        Console.WriteLine(kon1);
        kon1.GetInfoKontenerowiec();
    }
}