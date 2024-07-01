var set1 = new HashSet<int>();
var set2 = new HashSet<int>();

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = numbers[0];
int m = numbers[1];

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    set1.Add(number);
}

for (int i = 0; i < m; i++)
{   
    int number = int.Parse(Console.ReadLine());
    set2.Add(number);
}

var intersection = new HashSet<int>(set1);
intersection.IntersectWith(set2);

Console.WriteLine(String.Join(" ", intersection));
