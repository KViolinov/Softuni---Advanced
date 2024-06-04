var queue = new Queue<int>();

int quantityOfFood = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
  .Select(int.Parse)
  .ToArray();

for (int i = 0; i < orders.Length; i++)
{
    queue.Enqueue(orders[i]);
}

Console.WriteLine(orders.Max());

for (int i = 0; i < orders.Length; i++)
{
    if (quantityOfFood - orders[i] > 0) 
    {
        quantityOfFood -= orders[i];
        queue.Dequeue();
    }
    else
    {
        break;
    }
}


if (queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {String.Join(", ", queue)}");
}
