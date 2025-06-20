partial class Program
{
    static void ShowNumericTypes()
    {
        //Max value is 2,147,483,647
        int integerNumber = 42;

        //Max value is approximately 1.7E+308 should finish with 'd'
        double doubleNumber = 3.14159d;

        //Max value is approximately 3.4E+38 is smaller than double should finish with 'f'
        float floatNumber = 2.71828f;

        //Max value is 9,223,372,036,854,775,807 should finish with 'L' allow use "_" for readability
        long longNumber = 9223372036854775807L;

        //Max value is 32,767
        short shortNumber = 32767;

        // Max value is 79,228,162,514,264,337,593,543,950,335 used for financial calculations should finish with 'm'
        decimal decimalNumber = 79228.2015m;

        Console.WriteLine($"Integer: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Short: {shortNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");
    }
}