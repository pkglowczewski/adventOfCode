string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode\Resources\input_ex1.txt");
int sum = 0;
List<int> list = new List<int>();
foreach(var item in text)
{
    if(item != "")
    {
        sum = sum + Convert.ToInt32(item);
    }
    else
    {
        list.Add(sum);
        sum = 0;
    }
}
var result = list.OrderByDescending(x => x).FirstOrDefault();
Console.WriteLine(result);
Console.ReadKey();