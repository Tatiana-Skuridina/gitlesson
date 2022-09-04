// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N > M:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N - M + 1];
Console.WriteLine("Все натуральные числа от M до N:");
FillArray(array);

void FillArray(int[] matr)
{
    matr[0] = M;
    int sum = matr[0];
    Console.Write(matr[0] + " ");
    for (int i = 1; i < matr.Length; i++)
    {
        matr[i] = matr[i - 1] + 1;
        sum = sum + matr[i];
        Console.Write(matr[i] + " ");
    }
    Console.WriteLine();
    Console.Write("Сумма натуральных чисел от M до N: ");
    Console.Write(sum);
}


