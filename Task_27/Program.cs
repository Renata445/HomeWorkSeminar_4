int f(int a)
{
    int sum = 0, r;
    while(a != 0)
    {
        r = a%10;
        a = a/10;
        sum = sum + r;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));




 
            
