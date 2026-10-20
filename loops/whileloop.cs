using System;
using System.Collections.Generic;
using System.Text;

namespace loops
{
    public class whileloop
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int number = 5;
            int factorial = 1;

            while (number >= 1)
            {
                factorial *= number;
                number--;
            }

            Console.WriteLine("Factorial = " + factorial);

      
        

        int seconds = 5;

while (seconds > 0)
{
    Console.WriteLine(seconds);
    seconds--;
}

    Console.WriteLine("Launch!");
    }

}
}
