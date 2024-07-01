int n = int.Parse(Console.ReadLine());

var stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    if (command.Length == 2)
    {
        stack.Push(command[1]);
    }
    else
    {
        switch (command[0])
        {
            case 2:
                stack.Pop();
                break;
            case 3:
                Console.WriteLine(stack.Max());
                break;
            case 4:
                Console.WriteLine(stack.Min());
                break;
        }
    }
}

Console.WriteLine(String.Join(", ", stack));
/* 
1 x – Push the element x into the stack.
2 – Delete the element present at the top of the stack.
3 – Print the maximum element in the stack.
4 – Print the minimum element in the stack
*/
