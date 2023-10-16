/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(Sum(number));

int Sum(int num)
{
    int summ = 0;
    for (int i = num; i > 0; i /= 10)
    {
        summ = summ + i % 10;

    }
    return summ;
}
