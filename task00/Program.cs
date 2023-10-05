/*
0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
*/


System.Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

System.Console.WriteLine(result);