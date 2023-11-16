/*
69. Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в целую 
степень B с помощью рекурсии.
*/

Console.Clear();

int Step(int digit, int square)
{
    if(square == 1)
    {
        return digit;
    }
    else
    {
        return digit * Step(digit, square-1);
    }
}

int result = Step(3, 3);
System.Console.WriteLine(result);