using System;

namespace Project_14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            Console.WriteLine("Введите автора песни.");
            song.AuthorSong = Console.ReadLine();
            Console.WriteLine("Введите название песни.");
            song.NameSong = Console.ReadLine();
            Console.WriteLine("Введите год создание песни.");
            song.YearIssue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длительсноть песни.");
            song.DurationSong = Convert.ToDouble(Console.ReadLine());
        }
    }
}
