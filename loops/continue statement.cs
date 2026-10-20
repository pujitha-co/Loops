using System;
using System.Collections.Generic;
using System.Text;

namespace loops
{
    public class continue_statement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue; // Skip the rest of the loop body when i is 5
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop completed.");

            // skip negative numbers

            int[] numbers = { 10, -5, 20, -2, 30 };

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    continue;
                }

                Console.WriteLine(number);


                //Skip absent students

                bool[] attendance = { true, false, true, false, true };

                for (int i = 0; i < attendance.Length; i++)
                {
                    if (!attendance[i])
                    {
                        continue;
                    }

                    Console.WriteLine("Student " + (i + 1) + " is present");
                }
            }
        }
    }
}
