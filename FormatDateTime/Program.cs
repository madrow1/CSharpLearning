// See https://aka.ms/new-console-template for more information
DateTime AprilFools = new DateTime(2025,4,1,13,23,30);

// There are several formatting options available. 'd' returns a short date
Console.WriteLine($"{AprilFools:d}");

// 'D' returns a full date including the day and month written out
Console.WriteLine($"{AprilFools:D}");

// 'f Full date short
Console.WriteLine($"{AprilFools:f}");

// 'F' Full date but longer
Console.WriteLine($"{AprilFools:F}");

// 'g' Full date short notation
Console.WriteLine($"{AprilFools:g}");

// 'G' Full date short long notation
Console.WriteLine($"{AprilFools:G}");


string[] sampleDateTimes = {
    "Jan 1",
    "1/1/2025",
    "Jan 1, 2025, 7:30pm",
    "Jan 1 '15"
};

foreach (string datestr in sampleDateTimes) {
    DateTime result;
    if (DateTime.TryParse(datestr, out result)) {
        Console.WriteLine($"{datestr, -25} gets parsed as: {result}");
    }
    else {
        Console.WriteLine($"Could not parse '{datestr}");
    }
}