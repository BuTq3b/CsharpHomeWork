/* Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = new Random().Next();
System.Console.WriteLine(number);

if (number > 99)
{
    System.Console.WriteLine(number % 1000 / 100);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
