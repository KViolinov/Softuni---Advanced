int[] clothesAsArrayFromConsole = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int capasityOfRack = int.Parse(Console.ReadLine());

int racksUsed = 0;
int sum = 0;
int currentRackSum = 0;

var stack = new Stack<int>();

foreach (var cloth in clothesAsArrayFromConsole)
{
    stack.Push(cloth);
}

while (stack.Count > 0)
{
    int clothingValue = stack.Pop();

    if (currentRackSum + clothingValue <= capasityOfRack)
    {
        currentRackSum += clothingValue;
    }
    else
    {
        racksUsed++;
        currentRackSum = clothingValue;
    }
}

// If there were clothes on the last rack, increment rack count
if (currentRackSum > 0)
{
    racksUsed++;
}

Console.WriteLine(racksUsed);
