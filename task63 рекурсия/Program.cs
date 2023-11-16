/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

Console.Clear();

void DigitDiapas (int max, int start = 1)
{
    if(start>max)
    {
        return;
    }
    else
    {
        System.Console.Write(start + " ");
        DigitDiapas(max, start + 1);
    }
}

DigitDiapas(5);
