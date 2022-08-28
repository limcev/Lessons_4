// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] ter = new int[8];
int i = 0;

Console.WriteLine("Введите восемь цифр, которые станут элементами массива: ");
while (i < ter.Length)
{

    ter[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("Массив из восьми элементов: ");
Console.WriteLine(string.Join("/", ter));


