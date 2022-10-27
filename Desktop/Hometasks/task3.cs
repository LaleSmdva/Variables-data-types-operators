using System;

namespace Hometasks
{
    class task3
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 15;
            if(a <= b && a <= c)
            {
                Console.WriteLine("En kicik eded " + a + "-dir");
            }else if (b <= a && b <= c)
            {
                Console.WriteLine("En kicik eded " + b + "-dir");
            }
            else
            {
                Console.WriteLine("En kicik eded " + c + "-dir");
            }
        }
    }
}