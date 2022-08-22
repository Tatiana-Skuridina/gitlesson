// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] array = new int[6];
Random rand = new Random();
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int[] array2 = new int[3];
for (int i = 0, j = array.Length-1; i < array.Length && j > 0 && i < j; i++, j--)
{
    result = array[i] * array[j];
    Console.Write(array[i] + " " + array[j]);
    Console.WriteLine(" Произведение пар чисел: " + result);
    array2[i] = result;
}
Console.Write(array2[0] + " ");
Console.Write(array2[1] + " ");
Console.Write(array2[2]);