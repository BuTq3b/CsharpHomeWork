/* 16.Напишите программу, которая принимает на вход 
два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA/numberB == numberB || numberB/numberA == numberA)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
