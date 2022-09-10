// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void CorrectInput()
{
    if (col <= 0 || row <= 0)
    {
        Console.WriteLine("Некоректный ввод");
    }
}

CorrectInput();

int[,] NewMatrix()
{
    int[,] matrix = new int [row,col];
    Random rnd = new Random();
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<col; j++)
        {
        matrix[i,j] = rnd.Next(0,100);
        }
    }
    return matrix;
}

int[,] matrix = NewMatrix();

void MatrixPrint()
{
    for (int i=0; i<row; i++)
    {
        Console.WriteLine("");
        Console.Write("[");
        for (int j=0; j<col; j++)
        {
        Console.Write($"\t {matrix[i,j]} \t");
        }
        Console.Write("]");
    }
}
MatrixPrint();
Console.WriteLine("");
Console.WriteLine("Укажите строку искомого элемента");
int rowSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец искомого элемента");
int colSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void SearchNum()
{
    if (colSearch <= 0 || colSearch > col || rowSearch <= 0 || rowSearch > row)
    {
        Console.WriteLine("Данного элемента не существует.");
    }
    else
    {
        Console.WriteLine($"Искомый элемент: {matrix[rowSearch-1,colSearch-1]}");
    }
}

SearchNum();