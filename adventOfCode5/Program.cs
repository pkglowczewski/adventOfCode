using System.Collections;

string[] text = File.ReadAllLines(@"C:\Users\x\source\repos\adventOfCode\adventOfCode5\Resources\input_ex5.txt");

string[] arr = new string[] { "T", "P", "Z", "C", "S", "L", "Q", "N" };
Stack myStack1 = new Stack(arr);

string[] arr2 = new string[] { "L", "P", "T", "V", "H", "C", "G" };
Stack myStack2 = new Stack(arr2);

string[] arr3 = new string[] { "D", "C", "Z", "F" };
Stack myStack3 = new Stack(arr3);

string[] arr4 = new string[] { "G", "W", "T", "D", "L", "M", "V", "C" };
Stack myStack4 = new Stack(arr4);

string[] arr5 = new string[] { "P", "W", "C" };
Stack myStack5 = new Stack(arr5);

string[] arr6 = new string[] { "P", "F", "J", "D", "C", "T", "S", "Z" };
Stack myStack6 = new Stack(arr6);

string[] arr7 = new string[] { "V", "W", "G", "B", "D" };
Stack myStack7 = new Stack(arr7);

string[] arr8 = new string[] { "N", "J", "S", "Q", "H", "W" };
Stack myStack8 = new Stack(arr8);

string[] arr9 = new string[] { "R", "C", "Q", "F", "S", "L", "V" };
Stack myStack9 = new Stack(arr9);

object[] stacks = { myStack1, myStack2, myStack3, myStack4, myStack5, myStack6, myStack7, myStack8, myStack9 };
foreach (string line in text)
{
    var splittedLine = line.Split(' ');
    Stack temp = new Stack();
    for (int i = 0; i < Convert.ToInt32(splittedLine[1]); i++)
    {
        Stack fromStack = (Stack)stacks[Convert.ToInt32(splittedLine[3]) - 1];
        Stack toStack = (Stack)stacks[Convert.ToInt32(splittedLine[5]) - 1];
        var lastValue = fromStack.Pop();
        temp.Push(lastValue);
        if(temp.Count == Convert.ToInt32(splittedLine[1]))
        {
            while(temp.Count > 0)
            {
                toStack.Push(temp.Pop());
            }
        }

    }
}
foreach (Stack item in stacks)
{
    Console.Write(item.Peek());
}
Console.ReadKey();