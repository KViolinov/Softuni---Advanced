int n = int.Parse(Console.ReadLine());

var set = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string[] chemicalElements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < chemicalElements.Length; j++)
    {
        set.Add(chemicalElements[j]);
    }
}

SortedSet<string> sortedNames = new SortedSet<string>(set);

Console.WriteLine(String.Join(" ", sortedNames));
