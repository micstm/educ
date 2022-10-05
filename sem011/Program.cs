// ввод числа без ошибок
double varA;

while (true)
{
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out varA))
              break;
        Console.WriteLine("Ошибка ввода!");
}

Console.WriteLine($"A={varA}");





//Console.WriteLine("Hello, World!");
