//25
//цикл принимает на вход A и B и возводит A в натуральную степень B

int A = InputNumber("A");

int B;
while (true)
{
    B = InputNumber("B");
    if(B > 0) break;
}

int result = Stepen(A, B);

Console.WriteLine($"{A} в степени {B} -> {result}");

//----------

int InputNumber(string sym)
{
    while(true)
    {
        Console.Write($"Введите целое число {sym}: ");
        bool correct = int.TryParse(Console.ReadLine(),out int number);
        if(correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int Stepen(int a,int b)
{
    int count = 1,
        factor = a;
    while (count < b)
    {
        a *= factor;
        count++;
    }
    return a;
}