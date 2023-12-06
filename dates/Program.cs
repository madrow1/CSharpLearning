// See https://aka.ms/new-console-template for more information
// Datetime.Now is used to print the date and time as it is at the moment that it is called
DateTime now = DateTime.Now;
Console.WriteLine(now);

// Datetime today returns only the date, and assumes that the time is 1200am
DateTime today = DateTime.Today;
Console.WriteLine(today);

// DateOnly returns literally just the date.
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dt);

// TimeOnly returns literally only the time
TimeOnly to = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(to);

Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

now = now.AddDays(5);
now = now.AddHours(5);
now = now.AddMonths(5);

Console.WriteLine(now);

DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year,1,1);

TimeSpan interval = AprilFools - NewYears;

Console.WriteLine(interval);