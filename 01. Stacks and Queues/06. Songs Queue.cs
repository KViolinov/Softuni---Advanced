var songs = new Queue<string>();

// Read the initial song list
string[] initialSongs = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

foreach (string song in initialSongs)
{
    songs.Enqueue(song);
}

// Process commands until the queue is empty
while (songs.Count > 0)
{
    string command = Console.ReadLine();

    // Handle single-word commands (e.g., just "Play") and commands with arguments
    int spaceIndex = command.IndexOf(' ');
    string firstPart = spaceIndex == -1 ? command : command.Substring(0, spaceIndex); // Extract first word

    switch (firstPart)
    {
        case "Play":
            if (songs.Count > 0)
            {
                songs.Dequeue();
            }
            else
            {
                Console.WriteLine("No more songs!");
            }
            break;
        case "Add":
            if (spaceIndex != -1) // Check if there's an argument (space found)
            {
                string songToAdd = command.Substring(spaceIndex + 1).Trim(); // Extract and trim song name
                if (!songs.Contains(songToAdd))
                {
                    songs.Enqueue(songToAdd);
                }
                else
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
        default:
            Console.WriteLine("Invalid command!"); // Handle unknown commands
            break;
    }
}

while (Console.ReadLine() != null) { }
Console.WriteLine("No more songs!");
