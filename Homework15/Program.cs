﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет;

Console.Clear();
Console.WriteLine("Задача 15 ");

Console.Write("Введи номер деня недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
if (dayNumber == 6 || dayNumber == 7) 
    {
     Console.WriteLine("(этот день выходной) -> да");
    }
else if (dayNumber < 1 || dayNumber > 7) 
   {
   Console.WriteLine("Неделя состоит из семи дней. Введите пожалуйста другое число");
   }
else Console.WriteLine("(этот день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);


