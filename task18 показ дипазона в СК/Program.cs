/* 18. Напишите программу, которая по заданному номеру 
четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/
Console.Clear();
Console.Write("Введи номер четверти: ");
int number = int.Parse(Console.ReadLine());

if (number == 1) System.Console.WriteLine("x > 0 и y > 0");
if (number == 2) System.Console.WriteLine("x < 0 и y > 0");
if (number == 3) System.Console.WriteLine("x < 0 и y < 0");
if (number == 4) System.Console.WriteLine("x > 0 и y < 0");
if (number < 1 || number > 4) 
{
    System.Console.WriteLine("Введено неверное значение");
}