namespace Overriding;

public class Pizza : Order{
    public string Flavor { get; }

    // Could just use the other constructor with a default parameter for coupon of 0
    public Pizza(string customerName, string flavor) :
        base(customerName, $"Pizza", 999) {
        Flavor = flavor;
    }

    public Pizza(string customerName, string flavor, decimal coupon) :
        base(customerName, "Pizza", 999, coupon) {
        Flavor = flavor;
    }

    public new void PrintReceipt() {
        base.PrintReceipt();
        Console.WriteLine($"Flavor: {Flavor}");
    }

    public void Eat() {
        Console.WriteLine($"Nom, nom, nom. Yummy {Flavor} {ProductName}");
    }
}