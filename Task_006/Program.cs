﻿// Задача 6:
// Напишите программму, которая на вход принимает 
// число и выдает, является ли число четным (делится ли оно на
// два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

// Ввод данных
Console.Write("Введите целое число - ");
int num = int.Parse(Console.ReadLine());

// Решение
if (num % 2 == 0)
{
    Console.Write("Да ");
}
else
{
    Console.Write("Нет ");
}