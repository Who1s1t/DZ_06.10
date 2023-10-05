Console.WriteLine("Введите часы:");
int hourse = int.Parse(Console.ReadLine());
int ameba_zxc = 1;
if (hourse < 3)
{
    Console.WriteLine("Амёбы не размножились((((");
}
else { 
for (int i = 3;i <= hourse; i +=3)
{
    ameba_zxc *= 2;
}

Console.WriteLine($"Кол-во амёб {ameba_zxc}");
}