// Input two integers and display the larger one.
using System;
class Q3
{
    public static void Display()
    {
       
        int num1;
        int num2;

        Console.WriteLine("Enter a number");
          num1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter a Number");
          num2 = Convert.ToInt32 (Console.ReadLine());

          if(num1>num2)
          {
           Console.WriteLine("The First number is greater"); 
          }
          else{
            Console.WriteLine("The Second number is greater");
          }

    }
}

