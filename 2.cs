using System.Diagnostics;

Console.WriteLine("Кол-во дней:");
int s = Convert.ToInt32(Console.ReadLine());
double dist = 10;
double sum = 10;

for (int i = 1; i < s; i++)
{
    dist *= 1.1;
    sum += dist;
}
Console.WriteLine($"Оно пробежать: {sum}");
