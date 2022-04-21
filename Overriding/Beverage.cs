namespace Overriding;

public class Beverage : Order{
    public string Type { get; }

    public Beverage(string customerName, string type = "Water", decimal price = 99) :
        base(customerName, $"Drink", price) {
        Type = type;
    }

    public new void PrintReceipt() {
        base.PrintReceipt();
        Console.WriteLine($"Type: {Type}");
    }

    public void Drink() {
        Console.WriteLine("Blok, blok, blok");
        Console.WriteLine($"Nice {Type}");
    }
}