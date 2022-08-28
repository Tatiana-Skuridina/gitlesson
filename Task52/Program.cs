// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

void FindMedium(double result, int[,] matr)
{
    for (int i = 0; i <= matr.GetLength(0); i++) 
    {
        result = 0;
        for (int j = 0; j < matr.GetLength(1)-1; j++)
        {
            result = result + Convert.ToDouble(matr[j,i]);
        }
        Console.Write("{0:0.00};", (result/3));
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
double x = 0;
Console.WriteLine();
FindMedium(x, matrix);