using System.Globalization;

partial class Program
{

    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(2002, 9, 4);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days} dias");
    }
    static void DaysUntilNextBirthday()
    {
        //Timespan is a time interval not a date


        Console.Write("Introduce tu fecha de nacimiento (dd/mm/aaaa):");
        string birthDateString = Console.ReadLine()!;

        //Parse the string date to a DateTime variable
        //CultureInfo.InvariantCulture is for not changes between different regions
        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        //Get the next birthday considering month and day of birth
        DateTime nextBirthday = new DateTime(DateTime.Now.Year,birthDate.Month, birthDate.Day);

        //If the birthday has happened in this year add a year to the next birthday date
        if (nextBirthday < DateTime.Now)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        
        TimeSpan daysUntilBirthday = nextBirthday - DateTime.Now;
        Console.WriteLine($"You birthday is on {daysUntilBirthday.Days } days");
    }
}