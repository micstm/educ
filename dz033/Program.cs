//принимает на вход N и выдаёт таблицу кубов от 1 до N

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");
PrintCubes(N);

/////////////////////////

static void PrintCubes(int N)
{
    for(int i = 1; i < N; i++)
    {
        Console.Write($"{i*i*i}, ");
    }
    Console.Write($"{N*N*N}");
}
