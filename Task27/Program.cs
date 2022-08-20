// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// без использования математических методов
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToString(number).Length;
int ostatok = 0;
int result = 0;

int SumNumber(int number)
{
    for (int i = 0; i < count; i++)
    {
        ostatok = number - number % 10;
        result = result + (number - ostatok);
        number = number / 10;
    }
return (result);
}

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе равна " + sumNumber);

