// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());     
}

void CheckHundreds(int number)
{
    int сurrenе_number = number;
   
    if (сurrenе_number > 99)
    {
    while(сurrenе_number > 999)
    {
      сurrenе_number = сurrenе_number /10;
    }
    Console.WriteLine("Третья цифра введенного числа " + сurrenе_number%10);  
    }
    else
    {
        Console.WriteLine("Третьей цифры НЕТ!");
    }  
}

int number = GetNumber();
CheckHundreds(number);