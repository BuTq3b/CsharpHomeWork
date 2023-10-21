/*Напишите программу, которая находит сумму элементов с нечетными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
*/
Console.Clear();
Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] Arrey = NewRandomArrey(size);
PrintAr(Arrey);
System.Console.WriteLine();
PrintResult(Arrey);


int[] NewRandomArrey(int length)
{
    int[] newA = new int[length];

    for (int i = 0; i < newA.Length; i++)
    {
        newA[i] = new Random().Next(100, 1000);
    }
    return newA;
}

void PrintAr(int[] ar)
{
    foreach (var i in ar)
    {
        System.Console.Write(i + " ");
    }
}

void PrintResult(int[] ar)
{
    int sum = 0;
    for (int i = 1; i < ar.Length; i += 2)
    {
        
        sum += ar[i];

    }
    System.Console.Write($"Сумма элементов массива с нечетным индексом = {sum}");
}