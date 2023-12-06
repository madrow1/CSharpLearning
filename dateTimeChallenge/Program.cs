// See https://aka.ms/new-console-template for more information

string date;
DateTime today;
DateTime result;
TimeSpan ts;
today = DateTime.Today;


Console.WriteLine("Please enter a date");
date = Console.ReadLine();

if (date.ToUpper() == "EXIT") {
    Environment.Exit(0); 
}

if (DateTime.TryParse(date, out result)) {
    if (result < today) {
        ts = today - result;
        Console.WriteLine($"That date was {ts.Days} days before today");
    }
    if (result == today) {
        Console.WriteLine("That date is today");
    }
    if (result > today) {
        ts = result - today;
        Console.WriteLine($"That date is in {ts.Days} days");
    }
    }

else {
    Console.WriteLine($"Could not parse '{date}");
}
