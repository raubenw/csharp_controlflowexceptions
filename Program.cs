using System;

namespace ControlFlow
{

    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 100;
            int result;

            Console.WriteLine("What is your number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", number);

            // Testing if statements
            if (number > 50)
            {
                Console.WriteLine("In if number is larger than 50");
            }
            else if (number < 50)
            {
                Console.WriteLine("Number is too small");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }

            switch (number)
            {
                case 40:
                    Console.WriteLine("This is number {0}", number);
                    break;
                case 50:
                    Console.WriteLine("Here is number 50");
                    break;
                default:
                    Console.WriteLine("Some strange number");
                    break;
            }

            int[] my_array = { 3, 4, 9, 0, 10, 7 };
            for (int i = 0; i < my_array.Length; i++)
            {
                Console.WriteLine("At Index: {0},  Number is : {1}", i, my_array[i]);
            }

            foreach (int num in my_array)
            {
                Console.WriteLine("In for each num = {0}", num);
            }

            try
            {
                result = numerator / number;
                if (number > 1000)
                {
                    throw new ArgumentOutOfRangeException("number", "Number is greater than 1000");
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You tried to divid by Zero !");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException rangeException)
            {
                Console.WriteLine("Number is greater than 1000");
                Console.WriteLine(rangeException.Message);
            }
            finally
            {
                Console.WriteLine("And now finally, this code is always executed");
            }

        } // End Main
    }

}

