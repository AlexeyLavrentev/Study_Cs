// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int GetPow(int number1, int number2)
{
    int result = number1;
    int counter = 1;
    while (counter < number2)
    {
        result *= number1;
        counter++;
    }
    return result;
}

Console.Write("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} = {GetPow(num1, num2)}");