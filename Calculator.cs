using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCalculator
{
    class Calculator
    {
        public static int sum(int x, int y)
        {
            int sresult = x + y;
            return sresult;
        }
        public static int rest(int x, int y)
        {
            int sresult = (x) - (y);
            return sresult;
        }
        public static int mult(int x, int y)
        {
            int sresult = x * y;
            return sresult;
        }
        public static float div(float x, float y)
        {
            float sresult = x / y;
            return sresult;
        }
        public static void Procalculator()
        {
            int select = 0;
            int r1 = 0;
            int r2 = 0;
            int first = 0;
            int second = 0;
            Console.WriteLine("....................................................ProCalculator.......................................................");
            Console.WriteLine("\nPlease Select from [1-4] the operation you want to do:");
            do
            {
                try // It is used to catch errors or exceptions;  
                {   //display a error message if the user do not enter one number from the menu.
                    //Console.Clear();
                    Console.WriteLine("[1]. Addition");
                    Console.WriteLine("[2]. Substraction");
                    Console.WriteLine("[3]. Multiplication");
                    Console.WriteLine("[4]. Division");

                    select = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("This is the wrong entrance please choose between [1-4].");
                }
            }
            while (!(select == 1) && !(select == 2) && !(select == 3) && !(select == 4));//Condition that repeat 
            // the menu over and over until the user enter the right number within the menu. 
            switch (select)
            {
                case 1:
                    //Console.Clear();
                    Console.WriteLine("....................................................Addition......................................................");

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 1st Number:");
                            first = Int32.Parse(Console.ReadLine());
                            r1 = first / first;//Help the program to identify if the number is an integer.
                        }
                        catch//catch the error or the exception from the user entering the wrong data.
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r1 == 1));//keep the loop until the user enter a number and not something else.

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 2nd Number:");
                            second = Int32.Parse(Console.ReadLine());
                            r2 = second / second;
                        }
                        catch
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r2 == 1));


                    Console.WriteLine("The result of this {+} operation is: " + Calculator.sum(first, second));
                    // call the function that add the 2 number entered by the user and print the result of the [+].
                    break;

                case 2:
                    //Console.Clear();
                    Console.WriteLine("....................................................Subtraction......................................................");

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 1st Number:");
                            first = Int32.Parse(Console.ReadLine());
                            r1 = first / first;//Help the program to identify if the number is an integer.
                        }
                        catch//catch the error or the exception from the user entering the wrong data.
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r1 == 1));//keep the loop until the user enter a number and not something else.

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 2nd Number:");
                            second = Int32.Parse(Console.ReadLine());
                            r2 = second / second;
                        }
                        catch
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r2 == 1));


                    Console.WriteLine("The result of this {-} operation is: " + Calculator.rest(first, second));
                    // call the function that add the 2 number entered by the user and print the result of the [-].
                    break;
                case 3:
                    //Console.Clear();
                    Console.WriteLine("....................................................Multiplication......................................................");

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 1st Number:");
                            first = Int32.Parse(Console.ReadLine());
                            r1 = first / first;//Help the program to identify if the number is an integer.
                        }
                        catch//catch the error or the exception from the user entering the wrong data.
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r1 == 1));//keep the loop until the user enter a number and not something else.

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 2nd Number:");
                            second = Int32.Parse(Console.ReadLine());
                            r2 = second / second;
                        }
                        catch
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r2 == 1));


                    Console.WriteLine("The result of this {*} operation is: " + Calculator.mult(first, second));
                    // call the function that add the 2 number entered by the user and print the result of the [*].
                    break;
                case 4:
                    //Console.Clear();
                    Console.WriteLine("....................................................Division......................................................");
                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 1st Number:");
                            first = Int32.Parse(Console.ReadLine());
                            r1 = first / first;//Help the program to identify if the number is an integer.
                        }
                        catch//catch the error or the exception from the user entering the wrong data.
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r1 == 1));//keep the loop until the user enter a number and not something else.

                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 2nd Number:");
                            second = Int32.Parse(Console.ReadLine());
                            r2 = second / second;
                        }
                        catch
                        {
                            Console.WriteLine("This is the wrong entrance please choose right #");
                        }

                    } while (!(r2 == 1));


                    Console.WriteLine("The result of this {/} operation is: " + Calculator.div(first, second));
                    // call the function that add the 2 number entered by the user and print the result of the [/].
                    break;

            }

            //Console.ReadKey();

        }
    }


}

