/* 33. Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Clear();
System.Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
System.Console.WriteLine("Укажите число для поиска: ");
int number = int.Parse(Console.ReadLine());
int[] usserArr = RandomArr(size);
PrintArray(usserArr);
SerchNumber(usserArr, number);

int[] RandomArr(int lean)
{
    int[] newArrey = new int[lean];
    for (int i = 0; i < lean; i++)
    {
        newArrey[i] = new Random().Next(-9, 10);
    }
    return newArrey;

}

void SerchNumber(int[] arrey, int number)
{
    int num = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] == number)
            num++;
    }
    if (num > 0) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
   
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
        System.Console.Write(i + " ");

    System.Console.WriteLine();
}