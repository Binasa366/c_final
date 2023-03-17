﻿//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с 
//помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = ReadInt("Введите число N: ");
NatNumbers(n);



void NatNumbers(int number)
{
    if (number <= 1)
    {
        Console.Write(number);
    }
    else
    {
        Console.Write(number + ", ");
        NatNumbers(number - 1);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

