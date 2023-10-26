/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int[] arr = new int[8];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-99, 100);
    if (arr[i] > 0) {count++;}
}


void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
}

PrintArrey(arr);
System.Console.WriteLine();


System.Console.WriteLine($"Положительных чисел: {count}");