// удаляет вторую цифру трёхзначного случайного числа

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;

Console.WriteLine($"Число {num} => {a1 * 10 + a3}");