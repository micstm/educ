// 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


int A = InputNumber(1);
int B = InputNumber(2);
int C = InputNumber(3);

Console.Write($"Треугольник со сторонами A = {A}, B = {B}, C = {C} -> ");

TriangleCheck(A, B, C);

//--------------------

int InputNumber(int num)
{
    while (true)
    {
        Console.Write($"Введите {num} сторону: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


void TriangleCheck(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B)
        Console.WriteLine("существует");
    else
        Console.WriteLine("не существует");
}
