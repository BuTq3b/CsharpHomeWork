/*Напишите программу, которая принимает на вход 
число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine());
int number = Num(value);
System.Console.WriteLine(number);


int Num(int a)
{
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result *= i;
    }
    return result;
}