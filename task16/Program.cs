﻿// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом 
// другого.

Console.WriteLine("Введите первое число!");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int number2 = Convert.ToInt32(Console.ReadLine());

void CheckSquare(int number1, int number2)
{
if
(number1 == number2*number2 || number2 == number1*number1)
{
Console.WriteLine("да, является");
}
else
{
Console.WriteLine("нет, не является");
}
}
CheckSquare(number1, number2);
