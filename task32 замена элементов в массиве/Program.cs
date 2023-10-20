/* 32. Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();
System.Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] usserArr = RandomArr(size);
PrintArray(usserArr);
int[] newArr = DefArr(usserArr);
PrintArray(newArr);



int[] RandomArr(int lean)
{
    int[] newArrey = new int[lean];
    for (int i = 0; i < lean; i++)
    {
        newArrey[i] = new Random().Next(-9, 10);
    }
    return newArrey;

}

int[] DefArr(int[] arrey)
{


    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] != 0)
        {
            arrey[i] = -arrey[i];

    }
    return arrey;
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
        System.Console.Write(i + " ");

    System.Console.WriteLine();
}