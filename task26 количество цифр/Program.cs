/* 26. Напишите программу, которая принимает на 
вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
System.Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
int number = Num(value);
System.Console.WriteLine(number);


int Num(int a)
{
    int aver = 0;
    for (int i = a; i > 0; i/=10)
    {
        aver++;
    }
    return aver;
}

/*int userNum = 0;

System.Console.WriteLine(amountOfDigits(userNum));


int amountOfDigits(int userNum)
{
    int count = 0;
    while(userNum > 0)
    {
        userNum /= 10;
        count++;
    }
    
    return count;
}*/