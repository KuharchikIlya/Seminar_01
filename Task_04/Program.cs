﻿/*
Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.Write ("input number 1 => ");
int number1 = Convert.ToInt32(Console.ReadLine());

for (int i = -number1; i <= number1; i++)
{
    Console.Write (i);
}