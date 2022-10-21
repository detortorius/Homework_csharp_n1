/*Задача 4: Напишите программу,
которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/

Console.WriteLine("Введите Первое число");
string number1 = Console.ReadLine();
Console.WriteLine("Введите Второе число");
string number2 = Console.ReadLine();
Console.WriteLine("Введите Третье число");
string number3 = Console.ReadLine();

int num1 = int.Parse(number1);
int num2 = int.Parse(number2);
int num3 = int.Parse(number3);
int max = 0;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

    Console.Write($"Максмальное число = {max}");