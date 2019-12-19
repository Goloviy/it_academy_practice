using System;

namespace Lecture_6
{
    class Program
    {
        static void Main(string[] args)
        { char letter;
            Console.WriteLine("Введите несколько слов:");
            string str = Console.ReadLine();
            for (int i = 0; i > str.Length; i++)
            {
                int quantity = 0;
                if (str.Contains("a"))
                {
                    quantity ++;
                }
                i++;
                
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
