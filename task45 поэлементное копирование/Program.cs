/*
Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/
Console.Clear();
int[] arrey, newArrey;
int number;
Console.WriteLine("Введите длину массива рандомных чисел: ");
number = int.Parse(Console.ReadLine());
arrey = Arr(number);
PrintArrey(arrey);
System.Console.WriteLine();
newArrey = NewArrey(arrey);
PrintArrey(newArrey);



int[] Arr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}

int[] NewArrey(int[] arrey)
{
    int[] newA = new int[arrey.Length];
    for (int i = 0; i < arrey.Length; i++)
    {
        newA[i] = arrey[i];
    }
    return newA;
}

void PrintArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
}