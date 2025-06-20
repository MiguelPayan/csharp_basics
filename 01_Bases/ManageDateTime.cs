partial class Program
{
    static void ShowDateTime()
    {
        // Get the current date and time on this computer.
        DateTime now = DateTime.Now;

        // Get the current date.
        DateTime today = DateTime.Today;

        //Get the date of 7 days ago.
        DateTime oneWeekAgo = DateTime.Now.AddDays(-7);

        //DateTime.DateTime(int year, int month, int day, int hour, int minute, int second)
        DateTime customDate = new DateTime(2025, 06, 20, 8, 0, 0);

        //Get the day of the week using a date.
        DayOfWeek weekday = now.DayOfWeek;

        Console.WriteLine($"Current date and time: {now}");
        Console.WriteLine($"Current date: {today.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"7 days ago date: {oneWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Custom date: {customDate}");
        Console.WriteLine($"Week day of the current date: {weekday}");
    }
}