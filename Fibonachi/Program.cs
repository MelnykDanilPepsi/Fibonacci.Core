UInt64 num;
for(; ;)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Enter num,please   | 0 -exit");
        num = UInt64.Parse(Console.ReadLine());

    }
    catch { continue; }
    if (num == 0) break;

    Thread tr = new Thread(() =>
    Fibonacci(num)
    );
    tr.Start();
    Console.ReadKey();
}












void Fibonacci(UInt64 n)
{
    if (n == 0 || n == 1)
    {
        Console.WriteLine("Error num");
        return;
    }
    for(UInt64 i = 0; i < n;i++)
    {
        n += (n - 1) + (n - 2);
    }
    Console.WriteLine("Fibonacci num:"+ n);
}
