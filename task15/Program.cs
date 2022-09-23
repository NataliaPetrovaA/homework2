void task15()
{// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число!");
int day = Convert.ToInt32(Console.ReadLine());

if (day >0 && day<8)
{
    if(day == 6 || day == 7)
    {
    Console.WriteLine("Да, выходной день");
    }
    
    else
    {
    Console.WriteLine("Нет, рабочий день");
    }
}
else
{
Console.WriteLine("ОШИБКА! Введены не корректные данные!");
}
}
task15();