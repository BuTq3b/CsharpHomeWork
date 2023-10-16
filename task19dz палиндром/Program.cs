/* принимает на вход пятизначное число number и проверяет, 
является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, 
в противном случае - вывести Число не пятизначное и 
False в следующей строке.

Для остальных чисел вернуть True или False.
*/
System.Console.Write("Введите 5-значное число: ");
int number = int.Parse(Console.ReadLine());
int[]a = new int[5];
a[0] = number/10000;
a[1] = number/1000%10;
a[2] = number/100%10;
a[3] = number/10%10;
a[4] = number%10;

if (number < 10000 || number > 99999) System.Console.WriteLine("Введено не верное число");
else 
{
    if (a[0]==a[4] && a[1]==a[3]) System.Console.WriteLine("Данное число Палиндром");
else System.Console.WriteLine("Данное число не является Палиндромом");
}

