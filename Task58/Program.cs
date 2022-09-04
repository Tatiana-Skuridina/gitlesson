// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);
FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine("Матрица 1 после заполнения:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2 после заполнения:");
PrintArray(matrix2);
int[,] matr = new int[2, 2];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int k =0; k < matrix1.GetLength(0); k++)
        {
            matr[i, j] = matr[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Произведение двух матриц:");
PrintArray(matr);