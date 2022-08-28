// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]





int[] arry = new int [8];
int i = 0;
for (i = 0; i < arry.Length; i++)
{
       arry [i] = new Random().Next(0,2);
       Console.WriteLine(arry[i]);
}








// arry [] = new Random().Next(0,2);
// Console.WriteLine(arry[i]);
