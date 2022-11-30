// 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = InputNumber("k1");
double b1 = InputNumber("b1");
double k2 = InputNumber("k2");
double b2 = InputNumber("b2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Прямые  у = {k1}x + {b1}  и  y = {k2}x + {b2}  пересекаются в точке ( {x}; {y} )");


//----------

double InputNumber(string num)
{
    while (true)
    {
        Console.Write($"Введите {num}: ");
        bool correct = double.TryParse(Console.ReadLine(), out double number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}

