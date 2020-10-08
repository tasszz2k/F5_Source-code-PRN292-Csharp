using System;
using System.Collections.Generic;
using System.Text;

namespace MyFilmManagement
{
    class ManagementFilm
    {
        private CFilm[] listCFilms;

        public ManagementFilm()
        {
        }

        public ManagementFilm(CFilm[] listCFilms)
        {
            this.listCFilms = listCFilms;
        }

        public CFilm[] ListCFilms
        {
            get => listCFilms;
            set => listCFilms = value;
        }

        public CFilm this[int index]
        {
            get { return listCFilms[index]; }
            set
            {
                listCFilms[index] = value;
            }
        }

        public void InputData()
        {
            Validation validation = new Validation();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nEnter information of film[" + i + "]");
                Console.Write("Enter name:");
                String name = validation.getString(255);
                Console.Write("Enter length:");
                Double length = validation.getDouble(30, 150);
                Console.Write("Enter Producter:");
                String producter = validation.getString(9999);
                Console.Write("Enter Price:");
                Double price = validation.getDouble(-9999, 9999);
                Console.Write("Enter Number:");
                Double number = validation.getDouble(0, 100);

                listCFilms[i] = new CFilm(name, length, producter, price, number);

            }

        }

        public void Display()
        {
            foreach (CFilm cFilm in listCFilms)
            {
                Console.WriteLine("\nInformation of film:");
                Console.WriteLine(cFilm.ToString());
            }
        }

        public void search(String name)
        {
            Boolean isExist = false;
            foreach (CFilm cFilm in listCFilms)
            {
                if (name.Equals(cFilm.SName))
                {
                    Console.WriteLine("\nInformation of film:");
                    Console.WriteLine(cFilm.ToString());
                    isExist = true;
                }
            }

            if (!isExist)
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}
