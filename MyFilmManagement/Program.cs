using System;

namespace MyFilmManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CFilm[] listCFilms = new CFilm[3];
            ManagementFilm m = new ManagementFilm(listCFilms);
            m.InputData();
            m.Display();
            Console.WriteLine("\nSearch\nEnter name film:");
            String name = Console.ReadLine();
            m.search(name);
        }
    }
}
