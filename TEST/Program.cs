


int[] arry = new int [8];
int i = 0;
while ( i < arry.Length)
{
    arry[i] = new Random().Next(0,2);
    i++;
}
Console.WriteLine(string.Join("/", arry));