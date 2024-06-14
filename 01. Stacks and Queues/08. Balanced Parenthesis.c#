string input = Console.ReadLine();

var stack = new Stack<char>();
bool hasError = false; // Flag to track errors

foreach (char ch in input)
{
    switch (ch)
    {
        case '(':
        case '{':
        case '[':
            stack.Push(ch);
            break;
        case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                hasError = true;
                Console.WriteLine("NO");
            }
            break;
        case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
                hasError = true;
                Console.WriteLine("NO");
            }
            break;
        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                hasError = true;
                Console.WriteLine("NO");
            }
            break;
    }

    // Exit the loop after encountering an error
    if (hasError)
    {
        break;
    }
}

if (!hasError && stack.Count == 0) // Check for remaining elements in stack
{
    Console.WriteLine("YES");
}
else if (!hasError) // If no errors, check for extra opening parentheses
{
    Console.WriteLine("NO"); // Unbalanced if there are extra opening parentheses
}
