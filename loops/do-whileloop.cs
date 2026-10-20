using System;
using System.Collections.Generic;
using System.Text;

namespace loops
{
    public class do_whileloop
    {
        static void Main(string[] args)
        {
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
