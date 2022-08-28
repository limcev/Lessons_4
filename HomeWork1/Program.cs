// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int i = 1;
int step = 1;
while (i <= number2)
{
    step = step * number1;
    i++;
}
Console.WriteLine($"Число {number1} в {number2} степени будет равно {step}");

