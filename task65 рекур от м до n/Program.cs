/*
65. Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
*/

Console.Clear();

void DigitDiapas (int max, int start)
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

DigitDiapas(5,3);