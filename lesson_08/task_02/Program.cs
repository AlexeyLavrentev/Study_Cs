// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 4];
int[] row = new int[array.GetLength(0)];
int index = 0;

FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[i] += array[i,j];    
        }
    }

int min = row[0];

for (int i = 1; i < row.Length; i++) 
    { 
        if (min > row[i])
        {
            min = row[i];
            index = i;
            
        } 
    }
Console.WriteLine();
Console.Write($"{index + 1} строка");