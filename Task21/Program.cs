// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты x,y,z первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x,y,z второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int[] A = new int[3];
A[0] = x1;
A[1] = y1;
A[2] = z1;
int[] B = new int[3];
B[0] = x2;
B[1] = y2;
B[2] = z2;

double distance = Math.Sqrt((Math.Pow((x2 - x1),2)) + (Math.Pow((y2 - y1),2)) + (Math.Pow((z2 - z1),2)));
Console.WriteLine("{0:0.00}", distance);