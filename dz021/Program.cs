// вторая цифра трёхзначного числа

int number;
while (true)
{
    Console.Write("Введите трёхзначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (99 < number && number < 1000)
            break;
    }

    Console.WriteLine("Ошибка ввода!");
}

int num2 = (number / 10) % 10;

Console.WriteLine($"{number} -> {num2}");