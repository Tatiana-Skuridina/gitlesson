//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindPosition(int arg1, int arg2, int[,] matr)
{
    if (arg1 < matr.GetLength(0)) 
    {
        if (arg2 < matr.GetLength(1))
        {
        Console.WriteLine(matr[arg1, arg2]);
        }    
        else
        {
            Console.WriteLine("Такого числа в массиве нет");
        }
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

Console.WriteLine("Введите строку и столбец, соответствующие позиции числа");
string[] Array = Console.ReadLine().Split();
int x = int.Parse(Array[0]);
int y = int.Parse(Array[1]);
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
FindPosition(x, y, matrix);