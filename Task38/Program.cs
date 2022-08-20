// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(Console.ReadLine());
double maximum = array[0];
double minimum = array[0];
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maximum)
    {
        maximum = array[i];
    }
    if (array[i] < minimum)
    {
        minimum = array[i];
    }
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Максимальный элемент массива: " + maximum);
Console.WriteLine("Минимальный элемент массива: " + minimum);
Console.WriteLine("Разница между максимальным и минимальным: " + (maximum - minimum));