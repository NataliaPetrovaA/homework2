void task10()
{// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
if (number >99 && number< 1000)
    { 
    Console.WriteLine("Вторая цифра введенного числа " + (number/10%10));
    }
    else
    {
    Console.WriteLine("ОШИБКА! Число не трехзначное");
    }
}
task10();