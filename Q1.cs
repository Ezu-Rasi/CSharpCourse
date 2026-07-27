// Write a program to input a number and determine whether it is:
//  Positive
// Negative
// Zero
using System;
class Q1
{
    public static void Display()
    {
        
        int num;
        Console.WriteLine("Enter a number");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else 
        {
            Console.WriteLine("The number is zero");
        }

    }
}