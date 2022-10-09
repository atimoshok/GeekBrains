// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length !=5) Console.WriteLine("Число не пятизначное");
else
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("да, это полиндром");
    else Console.WriteLine("нет, это не полиндром");
}