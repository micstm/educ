//показывает все чётные числа от 1 до N

Console.Write("Введите целое число :");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int N = 2;
Console.Write(userNumber + " => ");
while (N <= userNumber) {
        Console.Write(N + ", ");
        N+=2;
    }