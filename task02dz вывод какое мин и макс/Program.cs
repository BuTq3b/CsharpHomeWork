/*
На вход принимает два числа и выводит,
какое число большее, а какое меньшее.
a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) Console.WriteLine($"число {numberA} больше числа {numberB}");
if (numberA < numberB) Console.WriteLine($"число {numberA} меньше числа {numberB}");
else Console.WriteLine($"числа {numberA} и {numberB} равны");
