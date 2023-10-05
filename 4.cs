double i;
int count = 0;
Console.WriteLine("Введите число для поиска:");
double zxc = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите число посдедовательности. Для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    if (i == zxc)
    {
        count += 1;

    }


}
Console.WriteLine(count);