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

int maxSum = 0;
int[,] matrix_maxSum = new int[3, 3];

for (int row = 0; row < rows - 2; row++) // Changed to rows - 1
{
    for (int col = 0; col < cols - 2; col++) // Changed to cols - 1
    {
        if ((matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]) > maxSum)
        {
            maxSum = 0;
            maxSum += (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]);

            matrix_maxSum[0, 0] = 0;
            matrix_maxSum[0, 1] = 0;
            matrix_maxSum[0, 2] = 0;
            matrix_maxSum[1, 0] = 0;
            matrix_maxSum[1, 1] = 0;
            matrix_maxSum[1, 2] = 0;
            matrix_maxSum[2, 0] = 0;
            matrix_maxSum[2, 1] = 0;
            matrix_maxSum[2, 2] = 0;

            matrix_maxSum[0, 0] = matrix[row, col];
            matrix_maxSum[0, 1] = matrix[row, col + 1];
            matrix_maxSum[0, 2] = matrix[row, col + 2];
            matrix_maxSum[1, 0] = matrix[row + 1, col];
            matrix_maxSum[1, 1] = matrix[row + 1, col + 1];
            matrix_maxSum[1, 2] = matrix[row + 1, col + 2];
            matrix_maxSum[2, 0] = matrix[row + 2, col];
            matrix_maxSum[2, 1] = matrix[row + 2, col + 1];
            matrix_maxSum[2, 2] = matrix[row + 2, col + 2];
        }
    }
}

Console.WriteLine("Sum = " + maxSum);

int rows1 = matrix_maxSum.GetLength(0); // Get number of rows
int cols1 = matrix_maxSum.GetLength(1); // Get number of columns

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols1; j++)
    {
        Console.Write(matrix_maxSum[i, j] + " "); // Print element with a space
    }
    Console.WriteLine(); // Move to next line after each row
}
