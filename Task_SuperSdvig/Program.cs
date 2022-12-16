Console.Clear();

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int [N];
for(int i = 0; i < N; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число K: ");
int K = Convert.ToInt32(Console.ReadLine());
if(K > 0)
{
    K %= N;
}
else
{
    K = N - ((-K) % N);
}
for(int i= N - K; i < N; i++)
{
    Console.WriteLine($"a = {a[i]}");
}
for(int i = 0; i < N - K; i++)
{
    Console.WriteLine($"a = {a[i]}");
}