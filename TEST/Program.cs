// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]




// int[] arry = new int[8];
// int i = 0;
// while (i < arry.Length)
// {
//     arry[i] = new Random().Next(-5, 6);
//      i++;

// }
// Console.WriteLine(string.Join("/", arry));

// int j = 0;

// while (j < arry.Length)
// {
//     arry [j] = arry [j] * -1;
//     j++;

// }
// Console.WriteLine(string.Join("/", arry));


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ

//  int[] arry = new int[8];
//  int i = 0;
//  while (i < arry.Length)
//  {
//      arry[i] = new Random().Next(-5, 6);
//       i++;

//  }
//  Console.WriteLine(string.Join("/", arry));


//  int j = 0;

//  while (j < arry.Length)
//  {
//      arry [j] = arry [j] * -1;
//      j++;

//  }
int[] Arry = Elements(123, 10, 99);
Console.WriteLine(string.Join("/ ", Arry));

int[] Elements(int size, int leftRange, int raitRange)

{
    int[] arry = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arry[i] = random.Next(leftRange, raitRange + 1);
    }
    return arry;
}


int j = 0;
int summa = 0;
while (j < Arry.Length)
{
    if ( Arry[j] >= 10 && Arry[j] <= 99)
    {
        summa = summa + 1;

    }
    if (10 < Arry[j] && Arry[j] > 99)
    {
       summa = summa + 0;
    }
    j++;
}
Console.Write("Количество двухзначных элементов массива: ");
Console.Write(summa);