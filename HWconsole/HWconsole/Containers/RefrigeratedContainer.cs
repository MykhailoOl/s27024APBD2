using HWconsole.Exceptions;

namespace HWconsole.Containers;

internal class RefrigeratedContainer: Container
{
    public PossibleProducts ProductsType { get; set; }
    private double CurrentTemperature { get; set; }

    public RefrigeratedContainer(PossibleProducts productsType,double  cargoMass, global::System.Double currentTemperature): base(cargoMass)
    {
        this.ProductsType = productsType;
        if ((double)productsType > currentTemperature)
        {
            throw new TooLowTemperature();
        }
        else {
            this.CurrentTemperature = currentTemperature;
        }
    }
    public void SetProductsType (PossibleProducts e)
    {
        if ((double)e > CurrentTemperature)
        {
            throw new TooLowTemperature();
        }
        else
        {
            ProductsType = e;
        }
    }

    public new virtual void Load(double cargoMass)
    {
        base.Load(cargoMass); 
    }
    public new virtual void Unload()
    {
        base.Unload();
    }
}