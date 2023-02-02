// Задача 2:
// Напишите программму, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

// Ввод данных от пользователя
Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

// Выявление Max
int max = num1;
if (num2 > max)
{
    max = num2;
}

// Вывод ответа
Console.WriteLine($"a = {num1}; b = {num2} -> max = {max}");
