/* который принимает на вход три числа и выдаёт 
максимальное из этих чисел.
*/

System.Console.WriteLine("Задай три числа: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;

if (number2 > maxNumber)
{
    maxNumber = number2;
}
if (number3 > maxNumber)
{
    maxNumber = number3;
}

System.Console.WriteLine(maxNumber);