using HWconsole.Exceptions;

namespace HWconsole.Containers;

internal class LiquidContainer : Container, IHazardNotifier
{
    public bool HasHazardousCargo { get; set; }

    public LiquidContainer(double cargoMass) : base(cargoMass)
    {
    }

    public new virtual void Load(double cargoMass)
    {
        base.Load(cargoMass);
        if((this.MaximumPayload/100*this.CargoMass>50 && HasHazardousCargo)
           || (this.MaximumPayload / 100 * this.CargoMass > 90 && HasHazardousCargo==false))
        {
            NotifyAboutHazard();
        }
    }
    public new virtual void Unload()
    {
        base.Unload();
    }

    public void NotifyAboutHazard()
    {
        Console.WriteLine("Dangerous operation. Overload of hazardous cargo. Notification about "+ Number as string);
    }
}