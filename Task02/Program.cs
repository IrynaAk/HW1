//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

using System;
using static System.Console;
Clear();

WriteLine("Type any number:");
int number = Convert.ToInt32(ReadLine());

if(number%2==0) 
{
    Write(number);
    WriteLine(" is even number");}
else
{   Write(number);
    WriteLine(" is odd number");}
