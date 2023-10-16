/* принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между 
ними в 3D пространстве.
*/

Console.Clear();
System.Console.Write("Введи координату XA: ");
int numXA = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату YA: ");
int numYA = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату ZA: ");
int numZA = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату XB: ");
int numXB = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату YB: ");
int numYB = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату ZB: ");
int numZB = int.Parse(Console.ReadLine());

// Расстояние (d) = √((x2 - x1)² + (y2 - y1)² + (z2 - z1)²)

double x = Math.Pow(numXB-numXA, 2);
double y = Math.Pow(numYB-numYA, 2);
double z = Math.Pow(numZB-numZA, 2);

double sqrt = Math.Sqrt(x + y + z);
System.Console.WriteLine(Math.Round(sqrt, 2));