// Задача 4:
// Напишите программму, которая на вход принимает 
// три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// Ввод данных от пользователя
Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());

// Выявление Max
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

// Вывод ответа
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");