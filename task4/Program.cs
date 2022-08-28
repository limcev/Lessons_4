






Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 1;
if (number1 < 1)
{
    Console.WriteLine("Ошибка. Введите число больше 0");
}
else
{
    for (i = 1; i <= number1; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine(sum);
}
