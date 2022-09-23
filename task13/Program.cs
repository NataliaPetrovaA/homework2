void task13()
{// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
//number = MaTh.Abs(number);
if (number >99)
{
    while(number > 999)
    {
        number /= 10;
    }
    Console.WriteLine("Тетья цифра введенного числа " + number%10);
}
else
{
    Console.WriteLine("ОШИБКА! Третьей цифры НЕТ!");
}
}
task13();