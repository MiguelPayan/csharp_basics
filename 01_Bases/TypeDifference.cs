using System.Reflection.Metadata.Ecma335;

partial class Program
{
    //This method shows the behaivor of different variables: Value Variables and Reference Variables
    static void TypesDifference()
    {
        int x = 5;
        int y = x;
        y = 15;
        //If you modify the variable "y", it doesn't have effect on "x" variable
        //  because this variables work with its own value despite that "y" has the "x" value assigned
        Console.WriteLine($"X: {x}, Y: {y}");

        Person person1 = new Person { Name = "Miguel" };
        Person person2 = person1;
        person2.Name = "Yahir";
        //If you modify the object person2, it has effect on person1 object because both are 
        // pointing to the same memory reference
        Console.WriteLine($"Person1 name: {person1.Name}");

    }

}

class Person
{
    public string? Name { get; set; }
}