// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GetNumber()
{
    int number = 0;
    while (number < 99 || number > 999)
    {
       Console.WriteLine("Введите число!");
       number = Convert.ToInt32(Console.ReadLine());  
    }
       return number;
}

void CheckDozens(int number)
{
    int сurrenе_number = number;

    while (сurrenе_number >= 99)
    {
        сurrenе_number = сurrenе_number /10;
    }

    int result = сurrenе_number % 10;
    Console.WriteLine("Вторая цифра введенного числа " + (result));
}      
   
int number = GetNumber();
CheckDozens(number);