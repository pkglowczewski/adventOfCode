string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode3\Resources\input_ex3.txt");
int sum = 0;
foreach(var line in text)
{
    var rucksackItems = line.Insert(line.Length / 2, " ").Split(" ");
    var duplicateLetters= line.GroupBy(c => c).Where(g => g.Count() > 1);
    foreach (var item in duplicateLetters)
    {
        if (rucksackItems[0].Contains(item.Key) && rucksackItems[1].Contains(item.Key))
        {
            sum += item.Key < 97 ? item.Key - 38 : item.Key - 96;
        }
    }
}
Console.WriteLine(sum);
Console.ReadKey();