using System;
using System.Collections.Generic;
using System.Text;

namespace loops
{
    public class breakstatement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // Exit the loop when i is 5
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop exited.");

            //search for a number

            int[] numbers = { 10, 20, 30, 40, 50 };
            int target = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine("Number found at index " + i);
                    break;
                }
            }
        }
    }
}
