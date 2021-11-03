using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

        public virtual string ShowInfo()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGender: {Gender}";
        }
    }
}
