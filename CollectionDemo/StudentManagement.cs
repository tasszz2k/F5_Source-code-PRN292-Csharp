using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class StudentManagement
    {
        public void EX1()
        {
            var students = new ArrayList();
            students.Add("Dinh");
            students.Add("Tuan");
            students.Add("Anh");
            AcceptDetail(students);
            DisplayDetail(students);
            int choice = 0;
            while(true)
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Sort(students);
                        break;
                    case 2:
                        Remove(students);
                        break;
                    case 3:
                        Reverse(students);
                        break;
                    case 4:
                        Search(students);
                        break;
                    default: return;
                }
            } 


        }

        public void AcceptDetail(ArrayList students)
        {
            char addMore = 'y';
            String studentName;
            do
            {
                Console.Write("Enter student's name: ");
                studentName = Console.ReadLine();
                students.Add(studentName);
                Console.Write("Do you want to add more name? [Y/N]: ");
                addMore = Console.ReadLine()[0];
            } while (addMore == 'y' || addMore == 'Y');

            Console.WriteLine();
        }

        public void DisplayDetail(ArrayList students)
        {
            Console.WriteLine();
            Console.WriteLine("List of students: ");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Total number of students : " + students.Count);
        }

        public int Menu()
        {
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("\t1. Sort");
            Console.WriteLine("\t2. Remove");
            Console.WriteLine("\t3. Reverse");
            Console.WriteLine("\t4. Search");
            Console.WriteLine("\t5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void Sort(ArrayList students)
        {
            students.Sort();
            Console.WriteLine("------ After sorting ------");
            DisplayDetail(students);
        }
        public void Remove(ArrayList students)
        {
            Console.Write("Enter name of student: ");
            String name = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ToString().Equals(name))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
               students.RemoveAt(index);

            }
            else
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine("----- After removing -----");
            DisplayDetail(students);
        }
        public void Reverse(ArrayList students)
        {
            students.Reverse();
            Console.WriteLine("------ After Reverse ------");
            DisplayDetail(students);

        }
        public void Search(ArrayList students)
        {
            Console.Write("Enter name of student: ");
            String name = Console.ReadLine();
            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ToString().Equals(name))
                {
                    index = i;
                }
            }

            if (index != -1)
            {
                Console.WriteLine("Index of student: " + index);

            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}
