using HWconsole.Containers;

namespace HWconsole;

class Ship
{
    public int MaxContainerNumber { get; set; }
    public List<Container> List { get; set; }
    public int MaxSpeed { get; set; }
    public double MaxContainersWeight { get; set; } // in tons
    public double CurrentLoad { get; set; }
    public double CurrentContainerNumber { get; set; }

    public void LoadContainer(Container c)
    {
        if (CurrentLoad + c.CargoLoad * 0.001 > MaxContainersWeight)
            throw new OverloadException();
        if (CurrentContainerNumber == MaxContainerNumber)
            Console.WriteLine("No place left.");
        List.Add(c);
        CurrentLoad += c.CargoLoad * 0.001;
        CurrentContainerNumber++;
    }
    public void LoadContainer(List<Container> cs)
    {
        double sumWeight = 0;
        foreach (Container c in cs)
            sumWeight+=c;
        if (CurrentLoad + sumWeight * 0.001 > MaxContainersWeight)
            throw new OverloadException();
        if (CurrentContainerNumber+cs.Count > MaxContainerNumber)
            Console.WriteLine("Not enough place left.");
        List.AddRange(cs);
        CurrentLoad += sumWeight * 0.001;
        CurrentContainerNumber++;
    }
}

internal class OverloadException : Exception
{
}