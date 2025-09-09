partial class Program
{
    static void ShowStringType()
    {
        // Link to string type documentation:
        // https://learn.microsoft.com/es-mx/dotnet/api/system.string?view=net-9.0

        string name = "Miguel Payan";

        // Concatenation using the + operator
        string greeting = "Hello, " + name + "!";

        // String interpolation instead of concatenation
        string message = $"Welcome to C#, {name}!";

        //String with multiple lines using @ 
        string severalLines = @"Welcome to C#, 
        regards from another line!
        This is a string with multiple lines.";

        severalLines += "\nThis is another line added to the string.";

        Console.WriteLine(greeting);
        Console.WriteLine(message);
        Console.WriteLine($"Your name has {name.Length} letters.");
        Console.WriteLine($"Your name in uppercase is {name.ToUpper()}");
        Console.WriteLine($"Your name in lowercase is {name.ToLower()}");
        Console.WriteLine(severalLines);

        int number = 22;
        Console.WriteLine(number.ToString());

        bool isString = true;
        Console.WriteLine(isString.ToString());
    }
    
}