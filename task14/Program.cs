// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());     
}

bool CheckMod(int a, int mod)
{
    return (a % mod == 0);
}

int a = GetNumber();
if (CheckMod(a,7) && CheckMod(a,23))
{
    Console.WriteLine("Число кратно одновременно 7 и 23!");
}
else
{
    Console.WriteLine("Число не кратно одновременно 7 и 23!");
}