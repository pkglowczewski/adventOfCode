string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode2\Resources\input_ex2.txt");
int sum = 0;
foreach (string line in text)
{
    var player1 = GetPlayerShape(line.Substring(0, 1));
    var player2 = GetPlayer2Shape(player1, line.Substring(2, 1));
    sum += player2;
}

Console.WriteLine(sum);
Console.ReadKey();

int GetPlayerShape(string letter)
{
    string shape = "";
    if (letter == "A")
    {
        shape = "ROCK";
    }
    if (letter == "B")
    {
        shape = "PAPER";
    }
    if (letter == "C")
    {
        shape = "SCISSORS";
    }
    return (int)Enum.Parse(typeof(Shapes), shape);
}
int GetPlayer2Shape(int player1, string letter)
{
    int shape=0;
    if (letter == "X")  // lose
    {
        if (player1 == 1)
        {
            player1 = 4;
        }
        shape = player1 - 1;
        sum += 0;
    }
    if (letter == "Y") // draw
    {
        shape = player1;
        sum += 3;
    }
    if (letter == "Z") // win
    {
        if (player1 == 3)
        {
            player1 = 0;
        }
        shape = player1 + 1;
        sum += 6;
    }
    return shape;
}
enum Shapes
{
    ROCK = 1,
    PAPER = 2,
    SCISSORS = 3
};
