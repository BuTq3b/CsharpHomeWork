/* 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("понедельник");
}
if (number == 2)
{
    System.Console.WriteLine("вторник");
}
if (number == 3)
{
    System.Console.WriteLine("среда");
}
if (number == 4)
{
    System.Console.WriteLine("четверг");
}
if (number == 5)
{
    System.Console.WriteLine("пятница");
}
if (number == 6)
{
    System.Console.WriteLine("суббота");
}
if (number == 7)
{
    System.Console.WriteLine("воскресенье");
}
else
{
    System.Console.WriteLine("Введено неверное число");
}