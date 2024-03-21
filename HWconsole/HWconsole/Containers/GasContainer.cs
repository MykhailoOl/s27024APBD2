using System.ComponentModel;
using HWconsole.Exceptions;

namespace HWconsole.Containers;

internal class GasContainer: Container, IHazardNotifier
{
    public double Pressure { get; set; }
    protected GasContainer(double cargoMass) : base(cargoMass)
    {
    }
    public virtual void Load(double cargoMass)
    {
        base.Load(cargoMass); 
    }
    public virtual void Unload()
    {
        this.CargoMass = (this.MaximumPayload / 100) * 5;
    }

    public void NotifyAboutHazard()
    {
        throw new NotImplementedException();
    }
}