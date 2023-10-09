/* 12.Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе 
число кратным первому. 
Если второе число некратно первому, то программа
выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
System.Console.WriteLine("Введите 2 числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA/numberB == numberB)
{
    System.Console.WriteLine("кратно");
}
else
{
        System.Console.WriteLine($"некратно, остаток {numberA%numberB}");
}