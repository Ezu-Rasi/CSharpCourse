//Declare three variables for Physics, Chemistry, and Mathematics marks, then calculate the total.
using System;

class Question3
{
    public static void Display()
    {
        int Physics = 79;
        int Chemistry = 80;
        int Mathematics = 81;

        int total = Physics+Chemistry+Mathematics;
        Console.WriteLine($"The total marks of Physics,Chemistry+Mathematics is {total}");
    }
}