// выходной?

int number;
while (true)
{
    Console.Write("Введите номер дня недели: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number > 0 && number < 8) break;
    Console.WriteLine("Ошибка ввода!");
}

if (number < 6)
    Console.WriteLine($"{number} -> нет");
else
    Console.WriteLine($"{number} -> да");