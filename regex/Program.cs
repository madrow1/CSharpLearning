// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog.";
string teststr2 = "the quick brown fox jumps over the lazy dog.";

Regex Capwords = new Regex(@"[A-Z]\w+");

Console.WriteLine(Capwords.IsMatch(teststr1));
Console.WriteLine(Capwords.IsMatch(teststr2));


Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);

Console.WriteLine(Capwords.IsMatch(teststr1));
Console.WriteLine(Capwords.IsMatch(teststr2));

// uses regex that matches capitalised words to return matches
Match m = Capwords.Match(teststr1);

// while m works this loop will return the value of the word matching regex, and its index
while (m.Success) {
    Console.WriteLine($"{m.Value} found at position {m.Index}");
    m = m.NextMatch();
}

string result = Capwords.Replace(teststr1, "***");

Console.WriteLine(result);

string MakeUpper(Match m) {
    string s = m.ToString();
    if (m.Index == 0) {
        return s;
    }
    return s.ToUpper();
}

string upperStr = Capwords.Replace(teststr1, new MatchEvaluator(MakeUpper));

Console.WriteLine(teststr1);
Console.WriteLine(upperStr);