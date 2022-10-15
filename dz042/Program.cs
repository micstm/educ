//27
//сумма цифр в числе

int number = InputNumber();
int sum = Summa(number);
Console.WriteLine($"{number} -> {sum}");

//----------

int InputNumber()
{
    while(true)
    {
        Console.Write("Введите число: ");
        bool correct = int.TryParse(Console.ReadLine(),out int number);
        if(correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int Summa(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num /= 10;
    }
    return sum;
}