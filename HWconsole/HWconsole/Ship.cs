using HWconsole.Containers;

namespace HWconsole;

class Ship
{
    public int MaxContainerNumber { get; set; }
    
    public int MaxSpeed { get; set; }
    public double MaxContainersWeight { get; set; } 
    private double CurrentLoad { get; set; }
    private double CurrentContainerNumber { get; set; }
    public List<Container> Containers { get; set; }

    public void LoadContainer(Container c)
    {
        if (CurrentLoad + c.CargoLoad * 0.001 > MaxContainersWeight)
            throw new OverloadException();
        if (CurrentContainerNumber == MaxContainerNumber)
            Console.WriteLine("No place left.");
        Containers.Add(c);
        CurrentLoad += c.CargoLoad * 0.001;
        CurrentContainerNumber++;
    }
    public void LoadContainer(List<Container> cs)
    {
        double sumWeight = 0;
        foreach (Container c in cs)
            sumWeight+=c.CargoLoad;
        if (CurrentLoad + sumWeight * 0.001 > MaxContainersWeight)
            throw new OverloadException();
        if (CurrentContainerNumber+cs.Count > MaxContainerNumber)
            Console.WriteLine("Not enough place left.");
        Containers.AddRange(cs);
        CurrentLoad += sumWeight * 0.001;
        CurrentContainerNumber++;
    }
    public void RemoveContainer(Container c)
    {
        UnloadContainer(c);
        Containers.Remove(c);
    }
    public void UnloadContainer(Container c)
    {
        int idx = Containers.IndexOf(c);
        if (idx > 0)
        {
            CurrentLoad -= Containers[idx].CargoLoad;
            Containers[idx].Unload();                
        }

    }
    public void LoadContainers(List<Container> cs)
    {
        double sumWeight = 0;
        foreach (Container c in cs)
            sumWeight+=c.CargoLoad;
        if (CurrentLoad + sumWeight * 0.001 > MaxContainersWeight)
            throw new OverloadException();
        if (CurrentContainerNumber+cs.Count > MaxContainerNumber)
            Console.WriteLine("Not enough place left.");
        Containers.AddRange(cs);
        CurrentLoad += sumWeight * 0.001;
        CurrentContainerNumber++;
    }
    public void ReplaceWithContainers(Container c, List<Container> cs)
    {
        RemoveContainer(c);
        LoadContainers(cs);
    }
    public static void TranferContainer(Container c, Ship from, Ship to)
    {
        from.RemoveContainer(c);
        to.LoadContainer(c);
    } 
    public override string ToString()
    {
        return base.ToString();
    }
}

internal class OverloadException : Exception
{
}