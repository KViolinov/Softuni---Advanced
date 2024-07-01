int numberOfElementsToPush, numberOfElementsToPop, numberToLookFor;
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Take(3)
    .ToArray();

numberOfElementsToPush = numbers[0];
numberOfElementsToPop = numbers[1];
numberToLookFor = numbers[2];

int[] numbersForStack = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Take(numberOfElementsToPush)
    .ToArray();

var stack = new Stack<int>();

foreach (var number in numbersForStack)
{
    stack.Push(number);
}

for (int i = 0; i < numberOfElementsToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(numberToLookFor))
{
    Console.WriteLine("true");
}
else if(!stack.Contains(numberToLookFor) && stack.Count > 0)
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine("0");
}
