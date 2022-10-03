namespace DateTimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            Console.WriteLine(date1);

            DateTime date2 = new DateTime(2020, 5, 10);
            Console.WriteLine(date2);

            DateTime date3 = new DateTime(2021, 11, 25, 18, 47, 22);
            Console.WriteLine(date3);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);

            Console.WriteLine(date2.DayOfWeek);
            Console.WriteLine(date2.Add(new TimeSpan(40, 20, 0, 0)));

            Console.WriteLine(date3.AddDays(-365));
            Console.WriteLine("\n---------------\n");
            Console.WriteLine(date2.ToLocalTime());
            Console.WriteLine(date2.ToUniversalTime());
            Console.WriteLine(date2.ToLongDateString());
            Console.WriteLine(date2.ToShortDateString());
            Console.WriteLine(date2.ToLongTimeString());
            Console.WriteLine(date2.ToShortTimeString());
            Console.WriteLine("\n---------------\n");
            Console.WriteLine($"D: {date2.ToString("D")}");
            Console.WriteLine($"d: {date2.ToString("d")}");
            Console.WriteLine($"F: {date2.ToString("F")}");
            Console.WriteLine($"f: {date2.ToString("f")}");
            Console.WriteLine($"G: {date2.ToString("G")}");
            Console.WriteLine($"g: {date2.ToString("g")}");
            Console.WriteLine($"M: {date2.ToString("M")}");
            Console.WriteLine($"O: {date2.ToString("O")}");
            Console.WriteLine($"R: {date2.ToString("R")}");
            Console.WriteLine($"s: {date2.ToString("s")}");
            Console.WriteLine($"T: {date2.ToString("T")}");
            Console.WriteLine($"t: {date2.ToString("t")}");
            Console.WriteLine($"U: {date2.ToString("U")}");
            Console.WriteLine($"u: {date2.ToString("u")}");
            Console.WriteLine($"Y: {date2.ToString("Y")}");
            Console.WriteLine("\n---------------\n");
            Console.WriteLine($"{date2.ToString("yyyy:MM:dd -- hh:mm")}");

            DateOnly dateOnly = new(2015, 12, 23);
            TimeOnly timeOnly = new(23, 55, 20);

            Console.WriteLine($"{dateOnly} {timeOnly}");
            Console.WriteLine($"{dateOnly.DayNumber}");
            Console.WriteLine($"{dateOnly.DayOfWeek}");
            Console.WriteLine($"{dateOnly.DayOfYear}");
            Console.WriteLine($"{dateOnly.Month}");
            Console.WriteLine($"{dateOnly.Year}");

            DateOnly dateOnly2 = DateOnly.Parse("11.7.2022");
            Console.WriteLine(dateOnly2);
        }
    }
}
