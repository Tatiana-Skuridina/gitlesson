// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[5];
nums[0] = number / 10000;
nums[1] = number / 1000 % 10;
nums[2] = number / 100 % 10;
nums[3] = number / 10 % 10;
nums[4] = number % 10;

Console.WriteLine("Число " + number + " является палиндромом?");
if ((nums[0] == nums[4]) && (nums[1] == nums[3]))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}