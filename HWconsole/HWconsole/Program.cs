// See https://aka.ms/new-console-template for more information

using HWconsole.Containers;
Console.WriteLine("Hello, World!");

int? a = 10;
a = null;
int b = 1;

// var container = new Container(100.0) { CargoMass = 125.0 };
// container.CargoMass = 100.0;

List<int> list = new List<int>() { 1, 2, 3 };
Dictionary<string, int> dictionary = new();

Dictionary<PossibleProducts, double> products = new Dictionary<PossibleProducts, double>();
products.Add(PossibleProducts.Bananas,13.3);
products.Add(PossibleProducts.Chocolate,18);
products.Add(PossibleProducts.Fish,2);
products.Add(PossibleProducts.Meat,-15);
products.Add(PossibleProducts.IceCream,-18);
products.Add(PossibleProducts.FrozenPizza,-30);
products.Add(PossibleProducts.Cheese,7.2);
products.Add(PossibleProducts.Sausages,5);
products.Add(PossibleProducts.Butter,20.5);
products.Add(PossibleProducts.Eggs,19);
    

Container container = new LiquidContainer(100.0);
LiquidContainer container2 = new LiquidContainer(100.0);
container.Load(100.0);
container2.Load(100.0);

var containerWithVarKeyword = new LiquidContainer(100.0);
const int d = 1;