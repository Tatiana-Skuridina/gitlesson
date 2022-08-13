// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int[] nums = {(number / 100), (number / 10 % 10), (number % 10)};
Console.WriteLine(nums[1]);