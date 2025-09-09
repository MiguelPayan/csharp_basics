partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 2;
        numbers[1] = 4;
        numbers[2] = 6;

        //If you dont need add and remove elements dinamically use arrays like this
        int[] numbersArray = [5, 10, 15, 20, 25, 30];

        //For accessing elements in an array, use the index beginning at 0
        Console.WriteLine($"First element: {numbersArray[0]}");
        Console.WriteLine($"Third element: {numbersArray[2]}");
        Console.WriteLine($"Array lenght: {numbersArray.Length}");

        //Accessing the elements reversely using negative index
        // this is a C# 8.0 feature and must use 1 instead of 0
        Console.WriteLine($"Last element: {numbersArray[^1]}");
        Console.WriteLine($"Penultimate element: {numbersArray[^1]}");

        // Use (..) for ranges of an array
        int[] range = numbersArray[1..4]; // This means just include the elements between first and fourth element (not including the fourth)
        foreach (var number in range)
        {
        Console.WriteLine($"Range of numbersArray:{number}");
        }
    }
}