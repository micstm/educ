//вывод третьей цифры

int number;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if (number < 100)
    Console.WriteLine($"{number} -> третьей цифры нет");
else
{
    int a = number;
    while (a > 999)
    {
        a /= 10;
        Console.WriteLine(a); //проверка работы
    }


    int num3 = a % 10;
    Console.WriteLine($"{number} -> {num3}");

}