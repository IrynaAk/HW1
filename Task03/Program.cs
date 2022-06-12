//адача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using static System.Console;
Clear();

WriteLine("Type any number:");
int number = Convert.ToInt32(ReadLine());

int currNumber = 2;

if(number<=1) {WriteLine("Your number should be >1.");}
else{
    while (currNumber<=number)
    {
        Write(currNumber);
        Write(", ");
        currNumber = currNumber+2;
    }
}