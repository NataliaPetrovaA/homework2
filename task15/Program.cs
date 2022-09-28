// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
int GetNumber()
{
    int number = 0;
    while (number < 1 || number > 7)
    {
       Console.WriteLine("Введите число!");
       number = Convert.ToInt32(Console.ReadLine());  
    }
       return number;
}

void CheckDayWeek(int number)
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("Выходной день");
    }
    
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
int number = GetNumber();
CheckDayWeek(number);