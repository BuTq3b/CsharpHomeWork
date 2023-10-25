/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

Console.WriteLine("Введите число N, для нахождения Фибоначи: ");
int n = int.Parse(Console.ReadLine());
int[] arey = Fibonachi(n);
Print(arey);

int[] Fibonachi(int number)
{
    int[] are = new int[number];
    if (number == 0)
        System.Console.WriteLine("Введен 0");
        
    if (number == 1)
        System.Console.WriteLine(1);
    else
    {
        are[0] = 0;
        are[1] = 1;
        for (int i = 2; i < number; i++)
        {
            are[i] = are[i - 1] + are[i - 2];
        }
    }
    return are;
}
void Print(int[] are)
{
    for (int i = 0; i < are.Length; i++)
    {
        System.Console.Write(are[i] + " ");
    }
}