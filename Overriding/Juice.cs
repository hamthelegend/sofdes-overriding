namespace Overriding;

public class Juice : Beverage{
    public string Flavor { get; }

    public Juice(string customerName, string flavor) : base(customerName, "Juice") {
        Flavor = flavor;
    }

    public new void PrintReceipt() {
        base.PrintReceipt();
        Console.WriteLine($"Flavor: {Flavor}");
    }

    public new void Drink() {
        base.Drink();
        Console.WriteLine($"You can kind of taste the {Flavor}");
    }

    public void Complain() {
        Console.WriteLine("Ugh. Who am I kidding? This tastes awful!");
    }
}