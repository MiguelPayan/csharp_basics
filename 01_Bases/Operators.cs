partial class Program
{
    static void Operators()
    {
        int number = 9;

        bool isEven = number % 2 == 0;

        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"The number {number} is even and greater than 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"The number {number} is not even but is greater than 10");
        }
        else
        {
            Console.WriteLine($"The number does not comply with the requirements");
        }

        //Operador ternario (?)
        int age = 12;
        string category = age > 18 ? "Mayor de edad" : "Menor de edad";

        Console.WriteLine(category);
    }
}