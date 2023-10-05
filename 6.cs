double i;
double sum = 0;
while (true)
{
    Console.WriteLine("Введите число посдедовательности. Для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    if (sum == 0)
    {
        sum = i;
    }
    else { 
    sum *= i;
    }
    Console.WriteLine($"Произведение: {sum}");


}