﻿// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.Write(i * i * i + ", ");
}