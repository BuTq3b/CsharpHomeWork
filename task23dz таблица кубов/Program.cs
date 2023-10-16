/* принимает на вход число (N) и выводит таблицу кубов
чисел от 1 до N (включительно) каждое на новой строке.*/

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine($"{i} + {i} = {i*i*i}");
}