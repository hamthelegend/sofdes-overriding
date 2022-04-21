using Overriding;

var chickenWings = new Order("Hamuel", "Chicken Wings", 599.75m);
chickenWings.PrintReceipt();
Console.WriteLine();

var discountedChickenWings = new Order("Jericho", "Chicken Wings", 599.75m, 199m);
discountedChickenWings.PrintReceipt();
Console.WriteLine();

var superDiscountedChickenWings = new Order("Jericho", "Chicken Wings", 599.75m, 999m);
superDiscountedChickenWings.PrintReceipt();
Console.WriteLine();

var hawaiianPizza = new Pizza("Justine", "Hawaiian");
hawaiianPizza.PrintReceipt();
Console.WriteLine();

var discountedHawaiianPizza = new Pizza("Blythe", "Hawaiian", 299m);
discountedHawaiianPizza.PrintReceipt();
discountedHawaiianPizza.Eat();
Console.WriteLine();

var water = new Beverage("Marc");
water.PrintReceipt();
water.Drink();
Console.WriteLine();

var juice = new Juice("Jonel", "Orange");
juice.PrintReceipt();
juice.Drink();
juice.Complain();
Console.WriteLine();