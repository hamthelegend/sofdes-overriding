namespace Overriding;

public class Order{
    public string CustomerName { get; }
    public string ProductName { get; }
    public decimal Price { get; }

    public decimal Coupon { get; }

    // Could just use the other constructor with a default parameter for coupon of 0
    public Order(string customerName, string productName, decimal price) {
        CustomerName = customerName;
        ProductName = productName;
        Price = price;
        Coupon = 0;
    }

    public Order(string customerName, string productName, decimal price, decimal coupon) {
        CustomerName = customerName;
        ProductName = productName;
        if (coupon <= price) {
            Price = price - coupon;
        }
        else {
            Price = 0;
        }

        Coupon = coupon;
    }

    public void PrintReceipt() {
        Console.WriteLine($"Thank you for buying from Hamuel's Pizza, {CustomerName}!");
        Console.WriteLine($"{ProductName}: P{Price:0.00}");
        if (Coupon > 0) {
            Console.WriteLine($"Coupon used: P{Coupon:0.00}");
        }
    }
}