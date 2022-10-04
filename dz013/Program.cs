// является ли число чётным

Console.Write("Введите целое число :");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber%2 == 0)
    {
        Console.WriteLine(userNumber + " => чётное");
    }
    else
        {
            Console.WriteLine(userNumber + " => нечётное");
        }