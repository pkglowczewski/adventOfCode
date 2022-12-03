var text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode3\Resources\input_ex3.txt").ToList();
int sum = 0;
while (text.Count > 0)
{
    var rucksackItems = text.Take(3).ToArray();
    string allLetters = "";
    foreach (var rucksackItem in rucksackItems)
    {
        allLetters += rucksackItem.ToString();
    }
    var duplicateLetters = allLetters.GroupBy(c => c).Where(g => g.Count() > 1);
    foreach (var item in duplicateLetters)
    {
        if (rucksackItems[0].Contains(item.Key) && rucksackItems[1].Contains(item.Key) && rucksackItems[2].Contains(item.Key))
        {
            sum += Convert.ToInt32(item.Key) < 97 ? Convert.ToInt32(item.Key) - 38 : Convert.ToInt32(item.Key) - 96;
        }
    }
    text.RemoveRange(0, 3);
}
Console.WriteLine(sum);
Console.ReadKey();