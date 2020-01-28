using System;
using System.Collections.Generic;
namespace Project_14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeightbors = new List<Neighbor>();

            floorNeightbors.Add(new Neighbor() { FullName = "Janna", FlatNumber = 10, PhoneNumber = 12332101 });
            floorNeightbors.Add(new Neighbor() { FullName = "Maksim", FlatNumber = 11, PhoneNumber = 38173213 });
            floorNeightbors.Add(new Neighbor() { FullName = "Ivan", FlatNumber = 9, PhoneNumber = 3218759 });
            floorNeightbors.Add(new Neighbor() { FullName = "Slava", FlatNumber = 12, PhoneNumber = 3816597 });
            floorNeightbors.Add(new Neighbor() { FullName = "Roma", FlatNumber = 13, PhoneNumber = 8759761 });

            int flatnumber;
            Console.WriteLine("Введите номер квартиры");
            Int32.TryParse(Console.ReadLine(), out flatnumber);

            for (int i = 0; i < floorNeightbors.Count; i++)
            {
                if (floorNeightbors[i].FlatNumber == flatnumber)
                {
                    Console.WriteLine($"Phone number:{floorNeightbors[i].FullName} \nName:{floorNeightbors[i].PhoneNumber}");
                }               
            }
        }
    }
}
