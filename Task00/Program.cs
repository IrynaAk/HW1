//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
using static System.Console;
Clear();

WriteLine("Type the first number:");
int number1 = Convert.ToInt32(ReadLine());

WriteLine("Type the second number:");
int number2 = Convert.ToInt32(ReadLine());

if (number1>number2)
{
    WriteLine("The first number is bigger than the second.");
}
else
{
    WriteLine("The second number is bigger than the first.");  
}