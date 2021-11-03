using Homework;
using System;

namespace Homework1222021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Talaba sayini daxil edin: ");
            int doctorCount = CountCheck();

            
            string name, surname, gender, speciality;
            int no,experience;
            Talaba talaba= new Talaba();
            for (int i = 0; i < doctorCount; i++)
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();
                Console.WriteLine("Soyad daxil edin:");
                surname = Console.ReadLine();
                Console.WriteLine("Cins qeyd edin:");
                gender = Console.ReadLine();
                Console.WriteLine("No daxil edin:");
                no = CountCheck();
                Console.WriteLine("Ixtisas daxil edin:");
                speciality = Console.ReadLine();
                Console.WriteLine("Tecrube ilinizi daxil edin:");
                experience = CountCheck();

                talaba.TalabaAdd(new Talaba()
                {
                    Name = name,
                    Surname = surname,
                    Gender = gender,
                    No = no,
                    Speciality = speciality,
                    Experience = experience
                });
                Console.Clear();
            }

            Console.WriteLine("--------------------------");

            foreach (var item in talaba.Talabas)
            {
                Console.WriteLine(item.ShowInfo());
            }
            
        }
        static int CountCheck()
            {
                string checkCountStr;
                int count;
                bool check = false;
                do
                {
                    if (check) Console.WriteLine("Eded daxil edin!");
                    checkCountStr = Console.ReadLine();
                    check = true;
                } while (!int.TryParse(checkCountStr, out count));
                return count;
            }
    }
}
