﻿// Задача 6:
// Напишите программму, которая на вход принимает 
// число N, а на выходе показывает все чётные числа от 1 до N 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Ввод данных
Console.Write("Ввведите число - ");
int num = int.Parse(Console.ReadLine());

// Решение
int count = 1;
while (count < num + 1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}