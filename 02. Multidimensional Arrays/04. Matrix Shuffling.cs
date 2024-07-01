// needs some work - 80/100 in judge

int[] dimentions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Take(2)
    .ToArray();

int rows = dimentions[0];
int cols = dimentions[1];

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    int[] rowElements = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .Take(cols)
        .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rowElements[j];
    }
}

//swap row1 col1 row2 col2
string[]? command; // Use nullable array type to handle empty input
while (true) // Loop indefinitely until break
{
    command = Console.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "END")
    {
        break;
    }

    if (command.Length == 0 && command.Length > 5 && command.Length < 5) // Check for empty input or invalid format
    {
        Console.WriteLine("Invalid input!");
        continue; // Skip to the next iteration
    }

    if (command[0] == "swap")
    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);

        if (row1 < 0 || row1 >= matrix.GetLength(0) ||
        col1 < 0 || col1 >= matrix.GetLength(1) ||
        row2 < 0 || row2 >= matrix.GetLength(0) ||
        col2 < 0 || col2 >= matrix.GetLength(1))
        {
            Console.WriteLine("Invalid input!");
            continue;
        }

        int temp = matrix[row1, col1];
        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = temp;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " "); // Print element with a space
            }
            Console.WriteLine(); // Move to next line after each row
        }
    }
}
