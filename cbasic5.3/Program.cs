/*3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
 */

using System;

namespace cbasic5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter Number: ");
            number =int.Parse(Console.ReadLine());
            for(i=1; i<= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of " + number+" is "+fact);
        }
    }
}
