using HWconsole.Exceptions;

namespace HWconsole.Containers;
using IContainer = Interfaces.IContainer;


public class Container : IContainer
{
    protected double CargoMass { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public static int Id { get; }
    public SerialNumber Number { get; set; }

    public double MaximumPayload { get; set; }
    public double  CargoLoad { get; set; }

    protected Container(double cargoMass)
    {
        CargoMass = cargoMass;
    }

    public void Load(double cargoMass)
    {
        if (cargoMass + CargoMass > MaximumPayload)
            throw new OverfillException();
        else
            CargoMass += cargoMass;
    }

    public void Unload()
    {
        CargoMass = 0;
    }
}