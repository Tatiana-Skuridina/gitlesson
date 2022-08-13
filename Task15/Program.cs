// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
string[] namesDay = {"Понедельник", 
                    "Вторник", "Среда", 
                    "Четверг", "Пятница", "Суббота",
                    "Воскресение"};
WriteSelect(namesDay);
Console.WriteLine("Укажите день недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вы выбрали " + namesDay[numberDay-1]);

static void WriteSelect(string[] args)
{
    for (int i = 0; i < args.Length-1; i++)
    {
        Console.Write(i+1 + " - " + args[i] + ", ");
    }
    Console.WriteLine(args.Length + " - " + args[args.Length-1] + ".");
}

Console.WriteLine(namesDay[numberDay-1] + " выходной?");
if (namesDay[numberDay-1] == "Суббота" || namesDay[numberDay-1] == "Воскресение")
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}