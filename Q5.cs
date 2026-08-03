// Input age and determine whether a person is eligible to vote (18 or above).
using System;
class Q5
{
    public static void Display()
    {
        int num1;
        int num2 = 18;

        Console.WriteLine("Enter your age");
        num1 = Convert.ToInt32(Console.ReadLine());
       

        if (num1>=num2)
        {
            Console.WriteLine("You are  eligible");
        }
      

        else
        {
            Console.WriteLine("you are not eligibe");
        }

        
    }

}
