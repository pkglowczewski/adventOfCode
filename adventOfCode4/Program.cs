string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode4\Resources\input_ex4.txt");
int sum = 0;
foreach (string line in text)
{
    var items = line.Split(',');
    var firstSetfirstEl = Convert.ToInt32(items[0].Split('-')[0]);
    var firstSetsecondEl = Convert.ToInt32(items[0].Split('-')[1]);
    var secondSetfirstEl = Convert.ToInt32(items[1].Split('-')[0]);
    var seocndSetsecondEl = Convert.ToInt32(items[1].Split('-')[1]);
    if (firstSetfirstEl <= secondSetfirstEl && firstSetsecondEl >= secondSetfirstEl 
        || firstSetfirstEl <= secondSetfirstEl && seocndSetsecondEl <= firstSetsecondEl 
        || firstSetfirstEl <= seocndSetsecondEl && firstSetsecondEl >= seocndSetsecondEl
        || secondSetfirstEl <= firstSetfirstEl && seocndSetsecondEl >= firstSetfirstEl
        || secondSetfirstEl <= firstSetfirstEl && firstSetsecondEl <= seocndSetsecondEl
        || secondSetfirstEl <= firstSetsecondEl && seocndSetsecondEl >= firstSetsecondEl)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);
Console.ReadKey();