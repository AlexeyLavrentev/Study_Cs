// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] FillSpiralArray(int n) 
{
    int[,] array = new int[n, n];

    int count = 1;

    int k = 0;

    while (count <= n*n && k <= n/2)
    {

        for (int j = k; j < n - 1 - k; j++) 
        {
            array[k, j] = count;
            count++;
        }



        for (int i = k; i < n - 1 - k; i++) 
        {
            array[i, n - 1 - k] = count;
            count++;
        }



        for (int j = n - 1 - k; j > k; j--) // 3-я линия - движение влево
        {
            array[n - 1 - k, j] = count;
            count++;
        }



        for (int i = n - 1 - k; i > k; i--) // 4-я линия - движение вверх
        {
            array[i, k] = count;
            count++;
        }


        k++;

    }

    if (n % 2 !=0) array [n/2,n/2] = count;

    return array;
}

void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10 )
            {
                Console.Write("0"+array[i, j] + " ");
                
                
            }
            else Console.Write(array[i, j] + " ");
            
        }
        Console.WriteLine();
    }
}


int size = 4;

int[,] array = FillSpiralArray(size);

PrintMatrix(array);