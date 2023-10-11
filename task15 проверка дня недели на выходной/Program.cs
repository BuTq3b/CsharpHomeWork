/* Задача 15: Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, является ли 
этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number = new Random().Next(1,8);
System.Console.WriteLine(number);

if (number < 6)
{
    System.Console.WriteLine("Рабочий день");
}
else
{
    System.Console.WriteLine("Выходной");
}