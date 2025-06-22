partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 2;
        numbers[1] = 4;
        numbers[2] = 6;

        //If you dont need add and remove elements dinamically use arrays like this
        int[] numbersArray = [5,10,15,20,25,30];

        Console.WriteLine($"First element: {numbersArray[0]}");
        Console.WriteLine($"Third element: {numbersArray[2]}");
        Console.WriteLine($"Array lenght: {numbersArray.Length}");
    }
}