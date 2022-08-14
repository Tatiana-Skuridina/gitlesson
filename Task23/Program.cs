// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N-1; i++)
{
    Console.Write(Math.Pow(i,3) + ", ");
}
Console.WriteLine(Math.Pow(N,3));