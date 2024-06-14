var dictionary = new Dictionary<int, int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (dictionary.ContainsKey(number))
    {
        dictionary[number]++; // Increment count for existing key
    }
    else
    {
        dictionary.Add(number, 1); // Add new key-value pair
    }
}

// Find the number with even occurrence (optimized)
int theNumber = 0;
foreach (KeyValuePair<int, int> pair in dictionary)
{
    if (pair.Value % 2 == 0) // Check count for evenness
    {
        theNumber = pair.Key;
        break; // Exit loop as soon as even number is found
    }
}

// Handle no even occurrence case
Console.WriteLine(theNumber);
