var text = File.ReadAllText(@"C:\Users\x\source\repos\adventOfCode\adventOfCode6\Resources\input_ex6.txt").ToCharArray();

int i = 0;
while (text.Length > 0)
{
    string result = $"{text[i]}{text[i+1]}{text[i+2]}{text[i+3]}";
    var groups = result.GroupBy(c => c).Where(g => g.Count() > 1);
    i++;
    if (groups.Count() == 0)
    {
        Console.WriteLine(i + 3);
        break;
    }
}
Console.ReadKey();