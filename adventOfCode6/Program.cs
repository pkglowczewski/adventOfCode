var text = File.ReadAllText(@"C:\Users\x\source\repos\adventOfCode\adventOfCode6\Resources\input_ex6.txt").ToCharArray();

int i = 0;
while (text.Length > 0)
{
    string result = "";
    for (int j = 0; j < 14; j++)
    {
        result += text[j+i];
    }
    var groups = result.GroupBy(c => c).Where(g => g.Count() > 1);
    if (groups.Count() == 0)
    {
        Console.WriteLine(i + 14);
        break;
    }
    i++;
}
Console.ReadKey();