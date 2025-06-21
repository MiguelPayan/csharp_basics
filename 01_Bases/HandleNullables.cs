partial class Program
{
    static void HandleNullable()
    {
        //No nullable
        string firstName = "Miguel";

        //Nullable
        string? lastName = null;
        Console.WriteLine($"Firstname: {firstName}");
        //Operador de coalesencia nula: [variable] ?? --
        // If somethign is null execute what it have next on the right
        Console.WriteLine($"LastName: {lastName ?? "'No lastname specified'"}");

        //Operador de acceso nulo: [variable]?.
        //Avoid the interruption of the program execution if the property is not accesible 
        string? email = null;
        Console.WriteLine($"The email has {email?.Length} characters");
        Console.WriteLine("Still in execution");
    }
}