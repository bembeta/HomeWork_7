/* Задача 50. Напишите программу, которая на вход принимает позиции
   элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

Console.Write("Введите строку: ");
int positionN = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int positionM = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; 
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("задан массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(0, 10);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (positionN < 0 | positionN > arr.GetLength(0) - 1 | positionM < 0 | positionM > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[positionN, positionM]);
}
