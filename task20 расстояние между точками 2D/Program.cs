/* B0. Напишите программу, которая принимает на вход 
координаты двух точек и находит
расстояние между ними в BD пространстве.


*/

Console.Clear();
System.Console.Write("Введи координату XA: ");
int numXA = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату YA: ");
int numYA = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату XB: ");
int numXB = int.Parse(Console.ReadLine());
System.Console.Write("Введи координату YB: ");
int numYB = int.Parse(Console.ReadLine());

double sqrX = Math.Pow(numXB - numXA, 2); // функция возводит в степень, нерез запятую указывается степеь
double sqrY = Math.Pow(numYB - numYA, 2);
double sqrt = Math.Sqrt(sqrX + sqrY); // Корень квадратный
System.Console.WriteLine(Math.Round(sqrt,2)); // Math.Round(sqrt,2) округляет знаки послезапятой (переменная, сколько знаков)