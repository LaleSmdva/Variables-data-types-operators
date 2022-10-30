using System;

namespace Hometaskss
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int number = 17;
            if (number > 0)
            {
                while (number % 2 == 0)
                {
                    number = number / 2;
                }
                if (number == 1)
                {
                    Console.WriteLine("It is a power of 2");
                }
                else
                {
                    Console.WriteLine("It is not a power of 2");

                }
            }


            else
            {
                Console.WriteLine("Enter a number greater than 0 ");
            }
            #endregion
            #region task2
            int n, number = 79897, remainder, sum = 0;
            n = number;

            if (number > 0)
            {
                while (number > 0)
                {
                    remainder = number % 10;
                    sum = sum * 10 + remainder;
                    number = number / 10;
                }
                if (n == sum)
                {
                    Console.WriteLine("This number is palindrome");
                }
                else
                {
                    Console.WriteLine("This number is not palindrome");
                }

            }
            else
            {
                Console.WriteLine("Choose a number greater than 0.");
            }
            #endregion
            #region task3
            int i, result = 0;
            int num = 17;
            if (num > 0)
            {
                for (i = 1; i <= num; i++)
                {

                    if (num % i == 0)
                    {
                        result++;
                    }
                }
                if (result == 2)
                {
                    Console.WriteLine("Sadedir");
                }
                else
                {
                    Console.WriteLine("Murekkebdir");
                }

            }
            else
            {
                Console.WriteLine("Enter a number greater than 0.");
            }
            #endregion
            #region task4
            string month = "July";
            switch (month)
            {
                case "December":
                case "January":
                case "February":
                    Console.WriteLine("WINTER");
                    break;
                case "March":
                case "April":
                case "May":
                    Console.WriteLine("SPRING");
                    break;
                case "June":
                case "July":
                case "August":
                    Console.WriteLine("SUMMER");
                    break;
                case "September":
                case "October":
                case "November":
                    Console.WriteLine("AUTUMN");
                    break;
                default:

                    Console.WriteLine("Invalid Month number");
                    break;
            }
            #endregion


        }
    }
}
