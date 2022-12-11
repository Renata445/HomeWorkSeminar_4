
int f(int a, int b)
{
    int result = 1;
    for(int i = 1; i<= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a,b));
