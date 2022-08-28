// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if (0 < day && day < 8)
{
    if (day == 6 || day == 7) Console.WriteLine("Это выходной день");
    else Console.WriteLine("Это рабочий день");
}
else Console.WriteLine("Ошибка, неверный номер дня.");