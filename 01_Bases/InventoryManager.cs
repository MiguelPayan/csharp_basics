partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Keyboard", "Mouse"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 45.00];

        Console.WriteLine("Inventory Report:");
        Console.WriteLine("------------------");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Product: {products[i]}, Stock: {stock[i]}, Price: ${prices[i]:F2}");
        }
        Console.WriteLine("------------------");
        Console.WriteLine("\nType the product you want to buy:");
        string? productToBuy = Console.ReadLine();
        Console.WriteLine("\nType the quantity you want to buy: ");
        int? quantity = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Equals(productToBuy, StringComparison.OrdinalIgnoreCase))
            {
                if (quantity <= stock[i])
                {
                    double total = double.Parse(quantity.ToString()!) * prices[i];
                    Console.WriteLine("_________________________");
                    Console.WriteLine($"\nTotal: {total}");
                    return;
                }
                else
                {
                    Console.WriteLine("\n There isn't stock");
                    
                }
            }
            
        }


    }
}