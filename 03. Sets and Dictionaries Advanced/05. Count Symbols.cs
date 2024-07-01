using System.Collections.Generic;

var dictionary = new Dictionary<char, int>();

string sentence = Console.ReadLine();

// Count character occurrences efficiently
for (int i = 0; i < sentence.Length; i++)
{
    char currentChar = sentence[i];

    if (dictionary.ContainsKey(currentChar))
    {
        dictionary[currentChar]++;
    }
    else
    {
        dictionary.Add(currentChar, 1);
    }
}

var sortedDictionary = new SortedDictionary<char, int>(dictionary);

// Print character counts with proper formatting
foreach (KeyValuePair<char, int> pair in sortedDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
}
