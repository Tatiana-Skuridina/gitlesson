// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// без использования математических методов
Console.WriteLine("Введите числа A, B:");
string[] Array = Console.ReadLine().Split(',');
int A = int.Parse(Array[0]);
int B = int.Parse(Array[1]);
if (B < 0) B = B * (-1);
int result = 1;
for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine(result);  