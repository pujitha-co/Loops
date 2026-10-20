using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace loops
{
    public class Nestedloops
    {
        static void Main(string[] args)
        {
            //Print a rectangle of stars

            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Outer loop iteration: " + i);
            //    for (int j = 1; j <= 2; j++)
            //    {
            //        Console.WriteLine("  Inner loop iteration: " + j);

                    // Print a number pattern
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(j + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    