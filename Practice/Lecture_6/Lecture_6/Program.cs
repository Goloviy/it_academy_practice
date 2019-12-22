using System;

namespace Lecture_6
{
    class Program
    {
        static void Main(string[] args)
        {   char letter = 'a' ;
            int quantity = 0;
            Console.WriteLine("Введите несколько слов:");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == letter)
                {
                    quantity ++;
                }                                               
            }
            Console.WriteLine("Количество букв а = "+quantity);
            Console.ReadLine();
        }
    }
}
