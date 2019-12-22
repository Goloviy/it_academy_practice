using System;

namespace Lectures_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string good_Morning = "Good morning, guys.";
            string good_Day = "Good day, guys.";
            string good_Evening = "Good evening, guys.";
            
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            var a = timeSpan.Hours;

            Console.WriteLine(timeSpan);
            if( a>9 && a <12)
            {
                Console.WriteLine(good_Morning);
            }
            if (a > 12 && a < 15)
            {
                Console.WriteLine(good_Day);
            }
            if (a > 15 && a < 22)
            {
                Console.WriteLine(good_Evening);
            }
                      
            Console.ReadLine();

            
        }
    }
}
