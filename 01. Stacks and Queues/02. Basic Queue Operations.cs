using System.Collections.Generic;

int numberOfElementsToEnqueue, numberOfElementsToDequeue, numberToLookFor;
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Take(3)
    .ToArray();

numberOfElementsToEnqueue = numbers[0];
numberOfElementsToDequeue = numbers[1];
numberToLookFor = numbers[2];

int[] numbersForStack = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Take(numberOfElementsToEnqueue)
    .ToArray();

var queue = new Queue<int>();

foreach (var number in numbersForStack)
{
    queue.Enqueue(number);
}

for (int i = 0; i < numberOfElementsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Contains(numberToLookFor))
{
    Console.WriteLine("true");
}
else if (!queue.Contains(numberToLookFor) && queue.Count > 0)
{
    Console.WriteLine(queue.Min());
}
else
{
    Console.WriteLine("0");
}
