// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a)
{
    Console.WriteLine("Большее число " + b);
    Console.WriteLine("Меньшее число " + a);
}
else 
{
    Console.WriteLine("Большее число " + a);
    Console.WriteLine("Меньшее число " + b);
}