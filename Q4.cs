// Write a program to find the smaller of two numbers.
using System;
class Q4
{
    public static void Display()
    {
        int num1;
        int num2;

        Console.WriteLine("Enter 1st Number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        num2 =Convert.ToInt32(Console.ReadLine());

        if(num1<num2)
        {
            Console.WriteLine("The 1st number is small");
        }
        else
        {
            Console.WriteLine("The 2nd number is small");
        }


    }

}