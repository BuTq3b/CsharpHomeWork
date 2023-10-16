/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
Console.Write("Введи число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Укажи степень в которую необходимо ввести данное число: ");
int numberB = int.Parse(Console.ReadLine());

double qard = Pow(numberA, numberB);

Console.WriteLine(qard);

double Pow(int a, int b)
{
    double qard = 0;
    qard = Math.Pow(a, b);
    return qard;
}

