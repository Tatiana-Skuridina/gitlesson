// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[4];
Random rand = new Random();
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
    if (i % 2 != 0)
    {
        result = result + array[i];
    }
    Console.Write(array[i] + " ");
}
Console.WriteLine(" Сумма элементов, стоящих на нечетных позициях: " + result);