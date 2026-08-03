// Write a C# program that checks whether a given integer is even or odd.
using System;
class Q2
{
    public static void Display()
    {
        
        Console.WriteLine("Enter a number");
       int num =  Convert.ToInt32(Console.ReadLine());

        if(num %2 == 0){
        Console.WriteLine("The number is even");
        }

        else{
        Console.WriteLine("The number is odd");
        }
    }
}