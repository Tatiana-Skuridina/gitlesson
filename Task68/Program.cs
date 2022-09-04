// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите положительное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0 & M > 0) 
{
    AkkermanFunction(M, N);
    Console.WriteLine($"A({M}, {N}) = {AkkermanFunction(M, N)}");
}
else Console.WriteLine ("Введены отрицательные числа, функция не может быть вычислена");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}