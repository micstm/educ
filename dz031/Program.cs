//пятизначный палиндром

int n;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (9999 < n && n < 100000)
            break;
    }

    Console.WriteLine("Ошибка ввода!");
}


if (n%10 == n/10000 && (n/10)%10 == (n/1000)%10)
    Console.WriteLine($"{n} -> да");
else
    Console.WriteLine($"{n} -> нет");