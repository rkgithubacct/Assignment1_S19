using System;
using System.Diagnostics;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 60); // Sets Console Size that accommodates output of this assignment
            

            int x, y;
            int []a = {1,2,3,2,2,1,3,2}; 
            int an = a.Length;

            x = 5;
            y = 25;
            Console.WriteLine("\n" + "Print Prime Numbers From " + x + " To " + y);
            printPrimeNumbers(x, y); /* calling printPrimeNumbers where starting range x is 5 and ending rante value of y is 25 */

            // Codes are Used to to check FindFactorial of each number provided in the assignment i.e. 2, 3 and 4 
            Console.WriteLine("\n" + "Calculate Factorial");
            Console.WriteLine("Factorial of " + 2 + " is " + FindFactorial(2));
            Console.WriteLine("Factorial of " + 3 + " is " + FindFactorial(3));
            Console.WriteLine("Factorial of " + 4 + " is " + FindFactorial(4));
            // Using method FindFactorial to computes the series 1/2 – 2!/3 + 3!/4 – 4!/5            
            Decimal dSeriesFact = (1/2) - (FindFactorial(2) / 3) + (FindFactorial(3) / 4) - (FindFactorial(4)) / 5;
            Console.WriteLine("Computed series of 1/2 – 2!/3 + 3!/4 – 4!/5 result is : " + dSeriesFact);


            // DrawTriangle method calls other methods to draw a Triangle using *
            x = 1;
            y = 15;
            Console.WriteLine("\n" + "Draw Triangle using Odd Numbers from " + x + " To " + y);
            drawTriangle(x, y); /* Draw a Triangle of odd numbers starting 1*/
            Console.WriteLine();

            // Count frequency of an element in the array and prints the result.
            Console.WriteLine("\n" + "Print Frequency of a number in Array" + "\n" + "\n" + "Number" + "\t" + "Frequency");
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i + "\t" + ComputeFrequency(a, an, i));
            }
            
            Console.ReadLine();
        } /* End Main Method */

        /* printPrimeNumbers input x and y both int, prints prime numbers between range from x to y */
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {

                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }           
        } /* End printPrimeNumbers */

        public static bool IsPrime(int i) /* Validate if Number is Prime or Not and Return true/false back to calling method */
        {
            try
            {
                int z = 2;
                Boolean bPrime = false;

                if ((i % z) != 0) /* if remainder then it is prime number */
                {
                    bPrime = true;
                }
                else
                {
                    bPrime = false;
                }

                return bPrime;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing IsPrime()");
                return false;
            }           
        } /* end IsPrime */

        public static int FindFactorial(int n) // Find Factorial of input parameter n
        {
            try
            {
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing FindFactorial()");
            }
            return 0;
        } // FindFactorial

        public static Boolean IsOdd(int n) // Validate if n is an Odd Number and Returns True/False
        {
            try
            {
                return n % 2 != 0;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing IsOdd()");
                return false;
            }            
        } // end IsOdd

        public static void drawTriangle(int x, int y) // Draw Triangle, printSpace method ensures the alignment 
        {
            try
            {
                for (int i = x; i <= y; i++)
                {
                    if (IsOdd(i))
                    {
                        Console.WriteLine();
                        int space = (y - i) / 2;
                        printSpace(space);
                        printTriangle(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing drawTriangle()");
            }            
        } // end drawTriangle
        
        public static void printTriangle(int n) // Prints Triangle using *
        {
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("*");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }            
        } // end printTriangle

        public static void printSpace(int n) // Method is used by drawTriangle to ensure alignment
        {
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(" ");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSpace()");
            }
        } // end printSpace

        public static int ComputeFrequency(int []a, int an, int x)  // calculates frequency of a number from an array and returns the count
        {
            try
            {
                int countFrequency = 0;
                for (int i = 0; i < an; i++)
                {
                    if (a[i] == x) countFrequency++;
                }
                return countFrequency;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing ComputeFrequency()");
                return 0;
            }
        } // end computeFrequency
    } // class Program
} // nameSpace
