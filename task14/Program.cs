void task14()
{// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите  число!");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 161 != 0)
Console.WriteLine($"число {number} не кратно числам 7 и 23 одновременно");
else
Console.WriteLine($"число {number} кратно числам 7 и 23 одновременно");
}
task14();