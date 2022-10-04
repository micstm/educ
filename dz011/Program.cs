// на вход принимает два числа и выдаёт, какое число больше

Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

if (userNumber1 > userNumber2)
    {
    Console.WriteLine("a= " + userNumber1 + ", b= " + userNumber2 + " -> max= " + userNumber1);
    }
else 
    {
    Console.WriteLine("a= " + userNumber1 + ", b= " + userNumber2 + " -> max=" + userNumber2);
    }
