// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (counter <= N)
{
    if (counter % 2 == 0)
    {
        if (counter == 2)
        {
            Console.Write(counter);
        }
        else
        {
            Console.Write("," + counter);
        }
    }
    counter = counter + 1;
}