/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int Sum(int m, int n)
{
    int summ = 0;
    if (m > n) return 0;

    else
    {
        summ = m + Sum(m + 1, n);

    }
    return summ;
}

int summa = Sum(1, 3);
System.Console.WriteLine(summa);