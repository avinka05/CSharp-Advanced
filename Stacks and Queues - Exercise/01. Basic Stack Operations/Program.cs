
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = numbers[0];
int s = numbers[1];
int x = numbers[2];

int[] numbersOfStack = Console.ReadLine().Split().Select(int.Parse).ToArray();


Stack<int> stack = new Stack<int>(numbersOfStack);

while (s>0&&stack.Any())
{
    stack.Pop();
    s--;
}

if(!stack.Any())
{
    Console.WriteLine(0)  ;
    return;
}

if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min();
}





