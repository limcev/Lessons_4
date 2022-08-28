// // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120





Console.Write("Введите чсило");
int number = Convert.ToInt32(Console.ReadLine());
int ter = 1;
int i = 1;
while (i <= number)
{
     ter = ter * i;  
     i++;
}
Console.WriteLine(ter);
