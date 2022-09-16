// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int sum = default;

int NaturalSum(int min, int max)
{
    if (min > max) return sum;
    sum = sum + min;
    NaturalSum(min+1,max);
    return sum;
}

if (m < n) sum = NaturalSum(m,n);
if (m > n) sum = NaturalSum(n,m);
else Console.WriteLine("Вы ввели некорректные числа.");
Console.WriteLine($"Cумма всех натуральных чисел в промежутке от {m} до {n} составляет: {sum} ");
Console.WriteLine("");