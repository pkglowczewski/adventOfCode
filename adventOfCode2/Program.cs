string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode2\Resources\input_ex2.txt");
int sum = 0;
foreach (string line in text)
{ 
    sum += OutcomePoint(GetPlayerShape(line.Substring(0, 1)), GetPlayerShape(line.Substring(2, 1))) + GetPlayerShape(line.Substring(2, 1));
}

Console.WriteLine(sum);
Console.ReadKey();

int OutcomePoint(int value, int value2)
{
    int difference = value - value2;
    switch (difference)
    {
        case -1:
        case 2:
            return 6;
        case -2:
            return 0;
        case 0:
            return 3;
        default:
            return 0;
    }
}

int GetPlayerShape(string letter)
{
    string shape = "";
    if (letter == "A" || letter == "X")
    {
        shape = "ROCK";
    }
    if (letter == "B" || letter == "Y")
    {
        shape = "PAPER";
    }
    if (letter == "C" || letter == "Z")
    {
        shape = "SCISSORS";
    }
    
    return (int)Enum.Parse(typeof(Shapes), shape);
}

enum Shapes
{
    ROCK = 1,
    PAPER = 2,
    SCISSORS = 3
};
