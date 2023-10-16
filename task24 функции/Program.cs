/* Напишите программу, которая принимает на вход 
число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
int number = Num(value);
System.Console.WriteLine(number);


int Num(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

/*
int value = 8;

int sum = SumOfNumberDigits(value);

System.Console.WriteLine(sum);


int SumOfNumberDigits(int num)
{
    int result = 0;
    for(int i = 1; i <= num;i++)
     {
        result = result + i;
     }
        
    return result;
}
*/