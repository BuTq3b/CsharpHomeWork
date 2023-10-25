/*Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Clear();
int number10, result, size;

number10 = int.Parse(Console.ReadLine());
result = 0;
size = 0;
size = SizeAr(number10);
int[] ar = Arre(number10, size);
Print(ar, size);


int SizeAr(int number)
{
    int result1 = 0;

    for (number = number; number > 0; number /= 2)
    {
        result1++;
    }

    return result1;
}

int[] Arre(int number, int size)
{
    int result = 0;
    int[] array = new int[size];


    for (int i = 0; i < size; i++)
    {
        result = number % 2;
        array[i] = result;
        number /= 2;
    }




    return array;
}

void Print(int[] arey, int size)
{
    int[] newAr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newAr[i] = arey[size - i - 1];
        Console.Write(newAr[i]);
    }
}