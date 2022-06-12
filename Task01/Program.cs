//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using static System.Console;
Clear();

WriteLine("Type the first number:");
int number1 = Convert.ToInt32(ReadLine());

WriteLine("Type the second number:");
int number2 = Convert.ToInt32(ReadLine());

WriteLine("Type the second number:");
int number3 = Convert.ToInt32(ReadLine());

int maxNumber = number1;

if(number1>maxNumber) {maxNumber = number1;}
if(number2>maxNumber) {maxNumber = number2;}
if(number3>maxNumber) {maxNumber = number3;}

Write("Mux number is: ");
WriteLine(maxNumber);