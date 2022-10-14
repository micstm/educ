// по номеру четверти, диапазон координат

int qwarter;
try
{
    Console.Write("Введите номер четверти: ");
    qwarter = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if (qwarter == 1)
    Console.WriteLine("x > 0 и y > 0");
else if (qwarter == 2)
    Console.WriteLine("x < 0 и y > 0");
else if (qwarter == 3)
    Console.WriteLine("x < 0 и y < 0");
else if (qwarter == 4)
    Console.WriteLine("x > 0 и y < 0");
else
    Console.WriteLine("Некорректно указана четверть!");