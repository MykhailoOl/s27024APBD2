namespace HWconsole.Containers;

internal class RefrigeratedContainer: Container
{
    public PossibleProducts ProductsType { get; }
    private double CurrentTemperature { get; set; }

    public RefrigeratedContainer(PossibleProducts productsType, global::System.Double currentTemperature)
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
    public setProductsType (PossibleProducts e)
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
        base.Load();
    }
}