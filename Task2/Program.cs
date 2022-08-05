// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int maximum = a;
if (b > a)
{
    maximum = b;
    if (c > b) 
    {
        maximum = c;
    }
}
else 
{
    if (c > a)
    {
        maximum = c;
    }
}
Console.WriteLine("Максимальное число " + maximum);