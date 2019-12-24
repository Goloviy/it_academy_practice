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
        }

    }
}
