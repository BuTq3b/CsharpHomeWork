/* Напишите программу, которая подсчитывает количество четных 
элементов в массиве целых положительных 
трехзначных чисел и выводит результат на экран.
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
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0)
        {
            System.Console.WriteLine($"{ar[i]} - ЧЕТНЫЙ ЭЛЕМЕНТ");
            sum ++;
        }
    }
    System.Console.WriteLine($"Количество четных элементов {sum}");
}