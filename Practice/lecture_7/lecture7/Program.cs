using System;

namespace lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать пустой массив нельзя, обязательно нужно указать его размер, можно создать массив с пустыми значениями,
            // для челочисленных значений будет значение 0.
            int[] array = new int[10];            
        }

        static void Task2 ()
        {
            object[] array = new object[3];

            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);                
            }
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                i += 2;
            }

            for (int i = 0; i < array.Length; i++)
            {   if (i == 0)
                {
                    //array[i] = (int)array[i];
                    int sum =(int)array[i]+10;
                    Console.WriteLine(sum);
                }
                if (i == 2)
                {
                    Console.WriteLine(array[i] + " guys!");
                }
            }

        }

        static void Task3 ()
        {
            int[] array = new int[13];
            int max  = 0;
            for( int i = 0; i < array.Length; i++)
            {                
                Random rnd = new Random();
                array[i] = rnd.Next();
                Console.WriteLine(array[i]);
                if(max < array[i])
                {
                    max = array[i];
                }
                if (i == 12)
                {
                    Console.WriteLine(max);
                }
            }
        }        

    }
}
