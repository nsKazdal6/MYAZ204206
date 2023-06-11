
//iteration ile 1'den n'e kadar sayıların toplamı

int iter_sum(int n)
{
    if (n == 0)
    {
        return 0;
    }
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

//recursive ile 1'den n'e kadar sayıların toplamı

int recursive_sum(int n)
{
    if (n ==1)
    {
        return 1;
    }
    return  n + recursive_sum(n-1);
}

//iteration ile faktöriyel hesap

int iter_fact(int n)
{
    if (n == 0) { return 1; }
    if (n == 1)
    {
        return 1;
    }
    int nul = 1;
    for (int i = 1; i <= n; i++)
    {
        nul *= i;
    }
    return nul;
}

//recursive ile faktöriyel hesap

int recursive_fact(int n)
{
    if (n == 0) { return 1; }
    if (n ==1)
    {
        return 1;
    }
    return n*recursive_fact(n-1);
}

//iteration ile bağlı liste elemanları üzerinde dolaşma

void iter_traversal(LinkedListNode<int> node)
{
    var current = node;
    Console.Write("Iteration  Traversal: ");
    while (current != null)
    {
        Console.Write(current.Value);
        current= current.Next;
    }
}

//recursive ile bağlı liste elemanlar üzerinde dolaşma
void recursive_traversal(LinkedListNode<int> node)
{
    if (node==null)
    {
        return;
    }
    Console.Write(node.Value + " ");
    recursive_traversal(node.Next);
    
}

//iteration ile fibonacci hesabı

int iter_fibonacci(int n)
{
    int a = 0;
    int b = 1;
    if (n == 0)
    {
        return 0;
    }
    if (n == 1)
    {
        return 1;
    }
    for (int i = 0; i < n; i++)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }

    return a;
}

//recursive ile fibonacci hesabı

int recursive_fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return recursive_fibonacci(n - 1) + recursive_fibonacci(n - 2);
    }
}





LinkedList<int> list = new LinkedList<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
int n = 5;
Console.WriteLine("iteration sum: " + iter_sum(n));
Console.WriteLine("recursive sum: " + recursive_sum(n));
Console.WriteLine("iteration fact: " + iter_fact(n));
Console.WriteLine("recursive fact: " + recursive_fact(n));
iter_traversal(list.First);
Console.Write("\nrecursive traversal: ");
recursive_traversal(list.First);
Console.WriteLine("\niteration fibonacci: " + iter_fibonacci(7));
Console.WriteLine("recursive fibonacci: " + recursive_fibonacci(7));
