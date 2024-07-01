int nSizeOfMatrix = int.Parse(Console.ReadLine());

int[,] matrix = new int[nSizeOfMatrix, nSizeOfMatrix];

for (int i = 0; i < nSizeOfMatrix; i++)
{
    int[] values = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .Take(nSizeOfMatrix)
        .ToArray();

    for (int j = 0; j < values.Length; j++)
    {
        matrix[i, j] = values[j];
    }
}

int sumPrimaryDiagonal = 0;
int sumSecondaryDiagonal = 0;

for (int i = 0; i < nSizeOfMatrix; i++)
{
    sumPrimaryDiagonal += matrix[i, i]; 
}

for (int i = 0; i < nSizeOfMatrix; i++)
{
    int j = nSizeOfMatrix - 1 - i; // Calculate index for secondary diagonal
    sumSecondaryDiagonal += matrix[i, j];
}

int difference = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
Console.WriteLine(difference);
