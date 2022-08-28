// Напишите программу, которая выводит третью цифру (справа налево) заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");         
int num = int.Parse(Console.ReadLine());  

if (num > 99)
{
    int num_2 = ((num / 100) % 10);
    Console.WriteLine($"Третья цифра {num_2}");
}
else Console.WriteLine("Третьей цифры нет");