// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10,99].

int[] array = new int[123];
Random rand = new Random();
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 999);
    if (array[i] <= 99 && array[i] >= 10)
    {
        result++;
    }
}
Console.WriteLine(" Количество чисел в отрезке [10, 99]: " + result);
