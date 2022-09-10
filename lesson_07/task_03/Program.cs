// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
Console.WriteLine("Среднее арефметическое столбцов:");

void ArithmeticMeanCol()
{
    double arithmeticMean = default;
    for (int j=0; j<col; j++)
    {
        arithmeticMean = 0;
        for (int i=0; i<row; i++)
        {
            arithmeticMean = arithmeticMean + matrix[i,j];
        }
        Console.Write($"\t {arithmeticMean/row} \t");
    }
}

ArithmeticMeanCol();
Console.WriteLine("");