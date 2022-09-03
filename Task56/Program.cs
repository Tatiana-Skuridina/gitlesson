// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,10);
        }
    }
}

static void FindMinSumLineArray(int[,] matr, int res)
{
    int minSum = matr[0, 0] + matr[0, 1] + matr[0, 2] + matr[0, 3];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        if (sum < minSum) 
        {
            minSum = sum; 
            res = i + 1;
        }
    }
    Console.Write("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: ");
    Console.Write(res + " строка");
}

int[,] matrix = new int[4, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
int result = 1;
FindMinSumLineArray(matrix, result);

