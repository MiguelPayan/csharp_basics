partial class Program
{
    static void SalesReport()
    {

        // :C and toString("C") are used to format numbers as currency.
        // The :C format specifier is used in string interpolation.
        string productName = "Laptop";
        int quantitySold = 7;
        double pricePerUnit = 999.99d;
        double totalPrice = quantitySold * pricePerUnit;
        string report = @"Product Sales Report
        -----------------------
        Product Name: " + productName + @"
        Produc Quantity Sold: " + quantitySold + @"
        Price per unit: $" + pricePerUnit.ToString("C") + @"
        -----------------------";

        Console.WriteLine(report);
        Console.WriteLine($"Total Sales: {totalPrice:C}");
    }

    static void SalaryCalculator()
    {
        // Using null-coalescing operator (??) to provide a default value if input is null
        // (!) operator is used to suppress nullability warnings when we are sure the value won't be null.
        Console.Write("Enter your name:");

        string? name = Console.ReadLine();

        Console.Write("Enter your salary per hour:");
        double? salaryPerHour = Double.Parse(Console.ReadLine()!);

        Console.Write("Enter the number of hours worked:");
        double hoursWorked = Double.Parse(Console.ReadLine()!);

        Console.WriteLine($"The salary of {name} is {(salaryPerHour * hoursWorked):C}");
    }
}
