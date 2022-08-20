// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[4];
Random rand = new Random();
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
    if (array[i] % 2 == 0)
    {
        result++;
    }
    Console.Write(array[i] + " ");
}
Console.WriteLine(" Количество четных чисел: " + result);