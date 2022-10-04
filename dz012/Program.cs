//на вход три числа и выдаёт максимальное

int max;

Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.Write("Введите третье целое число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber3 = int.Parse(userInput3);

if (userNumber1 > userNumber2)
    {
        max = userNumber1;
    }
    else
    {
        max = userNumber2;
    }

if (userNumber3 > max)
    {
        max = userNumber3;
    }

Console.WriteLine("a= " + userNumber1 + ", b= " + userNumber2 + ", c= " + userNumber3 + " -> max= " + max);

